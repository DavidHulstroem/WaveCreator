using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityEngine;

namespace WaveCreator
{
    public partial class Form1 : Form
    {
        public List<Group> groups = new List<Group>();

        public static string saveLocation;
        public static string streamingAssetsDirectory;

        public Group selectedGroup;

        public List<string> containerIds = new List<string>();
        public List<string> brainIds = new List<string>();
        public List<string> creatureTableIds = new List<string>();
        public List<string> mapIds = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

            //Check if data exists else create new
            if (File.Exists(strWorkPath + @"\StoredData.json"))
            {
                ProgramStoredData data = JsonConvert.DeserializeObject<ProgramStoredData>(File.ReadAllText((strWorkPath + @"\StoredData.json")));

                saveLocation = data.savePath;
                streamingAssetsDirectory = data.gamePath;

                SaveLoc.Text = data.savePath;
                StreaminAssetsTextBox.Text = data.gamePath;
            } else
            {
                GetFileLocations();
            }

            LoadAllAssets();

            
        }


        private void GetFileLocations()
        {
            ProgramStoredData data = new ProgramStoredData();

            FileLocations fileLocations = new FileLocations();
            if (fileLocations.ShowDialog() == DialogResult.OK)
            {
                data.gamePath = fileLocations.StreamLocSt;
                data.savePath = fileLocations.SaveLocSt;

                string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

                string json = JsonConvert.SerializeObject(data, Formatting.Indented);

                File.WriteAllText(strWorkPath + @"\StoredData.json", json);

                saveLocation = data.savePath;
                streamingAssetsDirectory = data.gamePath;

                SaveLoc.Text = data.savePath;
                StreaminAssetsTextBox.Text = data.gamePath;
            }
        }


        private void LoadAllAssets()
        {

            containerIds.Clear();
            brainIds.Clear();
            creatureTableIds.Clear();
            mapIds.Clear();



            //Get currently selected
            string containerSelected = ContainerDD.SelectedItem?.ToString();

            string creatureSelected = CreatureDD.SelectedItem?.ToString();

            string brainSelected = BrainDD.SelectedItem?.ToString();

            ContainerDD.DataSource = null;
            CreatureDD.DataSource = null;
            BrainDD.DataSource = null;


            //Find all containers
            string[] containers = Directory.GetFiles(streamingAssetsDirectory, "Container_*", SearchOption.AllDirectories);

            foreach (string file in containers)
            {
                string text = System.IO.File.ReadAllText(file);

                IdClass idClass = JsonConvert.DeserializeObject<IdClass>(text);

                if (!containerIds.Contains(idClass.id))
                {
                    containerIds.Add(idClass.id);
                }


            }

            //Find all brains
            string[] brains = Directory.GetFiles(streamingAssetsDirectory, "Brain_*", SearchOption.AllDirectories);

            foreach (string file in brains)
            {
                string text = System.IO.File.ReadAllText(file);

                IdClass idClass = JsonConvert.DeserializeObject<IdClass>(text);

                if (!brainIds.Contains(idClass.id))
                {
                    brainIds.Add(idClass.id);
                }
            }


            //Find all creature tables
            string[] creatueTables = Directory.GetFiles(streamingAssetsDirectory, "CreatureTable_*", SearchOption.AllDirectories);

            foreach (string file in creatueTables)
            {
                string text = System.IO.File.ReadAllText(file);

                IdClass idClass = JsonConvert.DeserializeObject<IdClass>(text);

                if (!creatureTableIds.Contains(idClass.id))
                {
                    creatureTableIds.Add(idClass.id);
                }
            }

            //Find all map ids
            string[] maps = Directory.GetFiles(streamingAssetsDirectory, "Level_*", SearchOption.AllDirectories);

            foreach (string file in maps)
            {
                string text = System.IO.File.ReadAllText(file);

                IdClass idClass = JsonConvert.DeserializeObject<IdClass>(text);

                if (!mapIds.Contains(idClass.id) && idClass.id != "Master" && text.Contains("LevelModuleWave"))
                {
                    mapIds.Add(idClass.id);
                }
            }

            ContainerDD.DataSource = containerIds;
            ContainerDD.SelectedItem = containerSelected;

            CreatureDD.DataSource = creatureTableIds;
            CreatureDD.SelectedItem = creatureSelected;

            BrainDD.DataSource = brainIds;
            BrainDD.SelectedItem = brainSelected;

            foreach (string text in mapIds)
            { 
                if (!WaveSelectorsInput.Items.Contains(text))
                {
                    WaveSelectorsInput.Items.Add(text);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group groupNew = new Group();
            groupNew.conditionStepIndex = groups.Count - 1;

            groups.Add(groupNew);


            GroupList.Items.Add(GroupList.Items.Count);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            if (GroupList.SelectedIndex != -1)
                selectedGroup = groups[GroupList.SelectedIndex];

            //show table
            //Set values

            BrainOverride.Checked = selectedGroup.overrideBrain;
            BrainDD.SelectedIndex = brainIds.FindIndex(x => x == selectedGroup.overrideBrainID);

            ContainerOverride.Checked = selectedGroup.overrideContainer;
            ContainerDD.SelectedIndex = containerIds.FindIndex(x => x == selectedGroup.overrideContainerID);

            CreatureDD.SelectedIndex = creatureTableIds.FindIndex(x => x == selectedGroup.referenceID);

            FactionOverride.Checked = selectedGroup.overrideFaction;
            FactionID.Value = selectedGroup.factionID;

            MaxMeleeOverride.Checked = selectedGroup.overrideMaxMelee;
            MaxMeleeCount.Value = selectedGroup.overrideMaxMeleeCount;

            MinMaxMin.Value = selectedGroup.minMaxCount.x;
            MinMaxMax.Value = selectedGroup.minMaxCount.y;

            spawnPointIndex.Value = selectedGroup.spawnPointIndex;
            conditionStepIndex.Value = selectedGroup.conditionStepIndex;
            conditionStepThreshold.Value = selectedGroup.conditionThreshold;


            tableLayoutPanel3.Visible = true;
        }

        private void UpdateGroupInfo()
        {
            if (selectedGroup != null)
            {
                selectedGroup.overrideBrain = BrainOverride.Checked;
                selectedGroup.overrideBrainID = brainIds[BrainDD.SelectedIndex];

                selectedGroup.overrideContainer = ContainerOverride.Checked;
                selectedGroup.overrideContainerID = containerIds[ContainerDD.SelectedIndex];

                selectedGroup.referenceID = creatureTableIds[CreatureDD.SelectedIndex];

                selectedGroup.overrideFaction = FactionOverride.Checked;
                selectedGroup.factionID = (int)FactionID.Value;

                selectedGroup.overrideMaxMelee = MaxMeleeOverride.Checked;
                selectedGroup.overrideMaxMeleeCount = (int)MaxMeleeCount.Value;

                selectedGroup.minMaxCount = new Vector2Int((int)MinMaxMin.Value, (int)MinMaxMax.Value);

                selectedGroup.spawnPointIndex = (int)spawnPointIndex.Value;
                selectedGroup.conditionStepIndex = (int)conditionStepIndex.Value;
                selectedGroup.conditionThreshold = (int)conditionStepThreshold.Value;
            }
        }

        private void SaveGroup_Click(object sender, EventArgs e)
        {
            UpdateGroupInfo();
        }

        private void FileBTN_Click(object sender, EventArgs e)
        {
            if (saveLocation == null)
            {
                MessageBox.Show("Save Location can not be null");
                return;
            }




            //Generate JSON
            WaveData waveDataJson = new WaveData();

            waveDataJson.type = "ThunderRoad.WaveData, Assembly-CSharp";
            waveDataJson.id = WaveIdInput.Text;

            waveDataJson.category = CategoryInput.Text;
            waveDataJson.title = TitleInput.Text;
            waveDataJson.description = DescriptionInput.Text;
            waveDataJson.loop = LoopInput.Checked;
            waveDataJson.maxAlive = (int)MaxAliveInput.Value;
            waveDataJson.alwaysAvailable = AlwaysAvailableInput.Checked;

            foreach (string obj in WaveSelectorsInput.CheckedItems)
            {
                waveDataJson.waveSelectors.Add(obj);
            }

            waveDataJson.playerHealthMultiplier = (float)PlayerHealthInput.Value;
            waveDataJson.enemiesHealthMultiplier = (float)EnemiesHealthInput.Value;

            waveDataJson.groups = groups;

            string json = JsonConvert.SerializeObject(waveDataJson, Formatting.Indented);

            json = json.Replace("\"type\"", "\"$type\"");

            File.WriteAllText(saveLocation + @"\Wave_" + waveDataJson.title + ".json", json);



        }

        private void NewWaveSelector_Click(object sender, EventArgs e)
        {
            WaveDialogForm();
        }

        public void WaveDialogForm()
        {
            WaveForm testDialog = new WaveForm();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                WaveSelectorsInput.Items.Add(testDialog.txtInput.Text);
            }
            testDialog.Dispose();
        }

        private void RemoveWave_Click(object sender, EventArgs e)
        {
            if (WaveSelectorsInput.SelectedIndex != -1)
            {
                WaveSelectorsInput.Items.Remove(WaveSelectorsInput.Items[WaveSelectorsInput.SelectedIndex]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetFileLocations();
            /*
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                saveLocation = folderBrowserDialog2.SelectedPath;
                SaveLoc.Text = folderBrowserDialog2.SelectedPath;
            }*/
        }

        private void LoadWaveJson_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string raw = System.IO.File.ReadAllText(openFileDialog1.FileName);

                WaveData readJson = JsonConvert.DeserializeObject<WaveData>(raw);

                WaveIdInput.Text = readJson.id;
                TitleInput.Text = readJson.title;
                CategoryInput.Text = readJson.category;
                DescriptionInput.Text = readJson.description;
                LoopInput.Checked = readJson.loop;
                AlwaysAvailableInput.Checked = readJson.alwaysAvailable;
                MaxAliveInput.Value = readJson.maxAlive;
                PlayerHealthInput.Value = (decimal)readJson.playerHealthMultiplier;
                EnemiesHealthInput.Value = (decimal)readJson.enemiesHealthMultiplier;


                WaveSelectorsInput.Items.Clear();

                foreach (string waveSelector in readJson.waveSelectors)
                {
                    WaveSelectorsInput.Items.Add(waveSelector);
                    WaveSelectorsInput.SetItemChecked(WaveSelectorsInput.Items.Count - 1, true);
                }

                groups.Clear();
                GroupList.Items.Clear();

                foreach (Group group in readJson.groups)
                {
                    groups.Add(group);
                    GroupList.Items.Add(GroupList.Items.Count);
                }
            }
        }

        private void RefreshAssets_Click(object sender, EventArgs e)
        {
            LoadAllAssets();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewContainerForm newContainerForm = new NewContainerForm();
            newContainerForm.Show(this);
        }

        private void RemoveGroup_Click(object sender, EventArgs e)
        {
            if (GroupList.SelectedIndex != -1)
            {
                groups.RemoveAt(GroupList.SelectedIndex);
                GroupList.Items.RemoveAt(GroupList.SelectedIndex);
                tableLayoutPanel3.Visible = false;
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/deusexmachinainc");
        }

        private void factionDesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FactionID_ValueChanged(object sender, EventArgs e)
        {
            factionDesc.SelectedIndex = (int)FactionID.Value + 1;
        }
    }

    public class ProgramStoredData
    {
        public string gamePath { get; set; }
        public string savePath { get; set; }
    }

    public class IdClass
    {
        public string id { get; set; }
    }


    public class WaveData
    {
        public string type { get; set; }
        public string id { get; set; }

        public int version { get; set; } = 2;

        public bool exludeFromBuild { get; set; } = false;
        public string category { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool loop { get; set; }
        public int maxAlive { get; set; }
        public bool alwaysAvailable { get; set; }
        public List<string> waveSelectors { get; set; } = new List<string>();

        public float playerHealthMultiplier { get; set; }
        public float enemiesHealthMultiplier { get; set; }

        public List<Group> groups { get; set; } = new List<Group>();
    }

    public class Group
    {
        public int reference { get; set; } = 1;

        public string referenceID { get; set; } = "NPCBanditMale1H";

        public bool overrideFaction { get; set; }

        public int factionID { get; set; }

        public bool overrideContainer { get; set; } = false;

        public string overrideContainerID { get; set; } = "NPCBandit1H";

        public bool overrideBrain { get; set; } = false;

        public string overrideBrainID { get; set; } = "HumanWarriorLv1";

        public bool overrideMaxMelee { get; set; }

        public int overrideMaxMeleeCount { get; set; }

        public Vector2Int minMaxCount { get; set; } = new Vector2Int(1, 1);

		public int spawnPointIndex { get; set; } = -1;

		public int conditionStepIndex { get; set; } = -1;

		public int conditionThreshold { get; set; }

        // Token: 0x02000425 RID: 1061
        public enum Reference
		{
			Creature,
			Table
		}
	}
}
