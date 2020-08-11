using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveCreator
{
    public partial class NewContainerForm : Form
    {
        public List<string> LootTables = new List<string>();
        public List<string> Apparels = new List<string>();
        public List<string> Weapons = new List<string>();
        public List<string> Shields = new List<string>();
        public List<string> Spells = new List<string>();

        public List<string> selectedReference = new List<string>();

        public List<Content> contents = new List<Content>();
        public List<CustomValues> customValues = new List<CustomValues>();

        public List<string> holders = new List<string>() {
            "None",
            "BackRight",
            "BackLeft",
            "HipsRight",
            "HipsLeft",
        };

        public Content selectedContent;
        public CustomValues selectedCV;

        public NewContainerForm()
        {
            InitializeComponent();
        }

        private void NewContainerForm_Load(object sender, EventArgs e)
        {

            //
            HolderSlotsDD.DataSource = holders;


            LoadAllAssets();
        }

        private void LoadAllAssets()
        {
            //Find all containers
            List<string> loottables = Directory.GetFiles(Form1.streamingAssetsDirectory, "LootTable_*", SearchOption.AllDirectories).ToList();

            loottables.AddRange(Directory.GetFiles(Form1.streamingAssetsDirectory, "Item_Apparel_*", SearchOption.AllDirectories));
            loottables.AddRange(Directory.GetFiles(Form1.streamingAssetsDirectory, "Item_Weapon_*", SearchOption.AllDirectories));
            loottables.AddRange(Directory.GetFiles(Form1.streamingAssetsDirectory, "Item_Shield_*", SearchOption.AllDirectories));
            loottables.AddRange(Directory.GetFiles(Form1.streamingAssetsDirectory, "Item_Spell_*", SearchOption.AllDirectories));

            foreach (string file in loottables)
            {
                string text = System.IO.File.ReadAllText(file);

                if (text.Contains("ThunderRoad."))
                {
                    try
                    {
                        IdClass idClass = JsonConvert.DeserializeObject<IdClass>(text);

                        if (file.Contains("LootTable_"))
                        {
                            if (!LootTables.Contains(idClass.id))
                            {
                                LootTables.Add(idClass.id);
                            }
                        }

                        if (file.Contains("Item_Apparel_"))
                        {
                            if (!Apparels.Contains(idClass.id))
                            {
                                Apparels.Add(idClass.id);
                            }
                        }

                        if (file.Contains("Item_Weapon_"))
                        {
                            if (!Weapons.Contains(idClass.id))
                            {
                                Weapons.Add(idClass.id);
                            }
                        }

                        if (file.Contains("Item_Shield_"))
                        {
                            if (!Shields.Contains(idClass.id))
                            {
                                Shields.Add(idClass.id);
                            }
                        }

                        if (file.Contains("Item_Spell_"))
                        {
                            if (!Spells.Contains(idClass.id))
                            {
                                Spells.Add(idClass.id);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("The file: " + file + " is either wrong or broken");
                        continue;
                    }
                }

            }

            CategoryDD.Items.Add("LootTables");
            CategoryDD.Items.Add("Apparels");
            CategoryDD.Items.Add("Weapons");
            CategoryDD.Items.Add("Shields");
            CategoryDD.Items.Add("Spells");

            selectedReference = LootTables;

            ReferenceDD.DataSource = selectedReference;
        }

        private void ContentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            CustomValuesBox.SelectedIndex = -1;

            HolderSlotsDD.SelectedIndex = 0;

            if (ContentList.SelectedIndex != -1) 
                selectedContent = contents[ContentList.SelectedIndex];

            if (selectedContent == null)
                return;

            int index = 0;

            if (LootTables.Contains(selectedContent?.referenceID))
            {
                //selectedReference = LootTables;
                index = 0;
            }
            if (Apparels.Contains(selectedContent?.referenceID))
            {
                //selectedReference = Apparels;
                index = 1;
            }
            if (Weapons.Contains(selectedContent?.referenceID))
            {
                //selectedReference = Weapons;
                index = 2;
            }
            if (Shields.Contains(selectedContent?.referenceID))
            {
                //selectedReference = Shields;
                index = 3;
            }
            if (Spells.Contains(selectedContent?.referenceID))
            {
                //selectedReference = Spells;
                index = 4;
            }

            CategoryDD.SelectedIndex = index;

            ReferenceDD.SelectedIndex = selectedReference.FindIndex(x => x == selectedContent.referenceID);

            referenceInput.Value = selectedContent.reference;

            QuantityInput.Value = selectedContent.quantity;

            customValues.Clear();
            CustomValuesBox.Items.Clear();

            foreach (CustomValues customVal in selectedContent.customValues)
            {
                customValues.Add(customVal);
                CustomValuesBox.Items.Add(CustomValuesBox.Items.Count);
            }

            tableLayoutPanel1.Visible = true;
        }

        private void NewGroup_Click(object sender, EventArgs e)
        {
            Content contentNew = new Content();
            
            contents.Add(contentNew);
            ContentList.Items.Add(ContentList.Items.Count);
        }

        private void CustomValuesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomValuesBox.SelectedIndex != -1)
            {
                selectedCV = customValues[CustomValuesBox.SelectedIndex];

                CVId.Text = selectedCV.id;
                CVValue.Text = selectedCV.value;

                tableLayoutPanel3.Visible = true;
            }
        }

        private void NewCustomValue_Click(object sender, EventArgs e)
        {
            CustomValues cvNew = new CustomValues();

            customValues.Add(cvNew);
            CustomValuesBox.Items.Add(CustomValuesBox.Items.Count);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Custom value save
            if (selectedCV != null)
            {
                selectedCV.id = CVId.Text;
                selectedCV.value = CVValue.Text;
            }

            selectedContent.referenceID = selectedReference[ReferenceDD.SelectedIndex];
            selectedContent.reference = (int)referenceInput.Value;

            selectedContent.customValues.Clear();



            if (HolderSlotsDD.SelectedIndex > 0)
            {
                selectedContent.customValues.Add(new CustomValues("Holder", holders[HolderSlotsDD.SelectedIndex]));
            }

            if (customValues.Count > 0)
                selectedContent.customValues.AddRange(customValues);

            selectedContent.quantity = (int)QuantityInput.Value;


        }

        private void RemoveContent_Click(object sender, EventArgs e)
        {
            if (ContentList.SelectedIndex != -1)
            {
                contents.RemoveAt(ContentList.SelectedIndex);
                ContentList.Items.RemoveAt(ContentList.SelectedIndex);

                tableLayoutPanel1.Visible = false;
            }
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemoveCV_Click(object sender, EventArgs e)
        {
            if (CustomValuesBox.SelectedIndex != -1)
            {
                customValues.RemoveAt(CustomValuesBox.SelectedIndex);
                CustomValuesBox.Items.RemoveAt(CustomValuesBox.SelectedIndex);

                tableLayoutPanel3.Visible = false;
            }
        }

        private void LoadContainerJson_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string raw = System.IO.File.ReadAllText(openFileDialog1.FileName);

                Container readJson = JsonConvert.DeserializeObject<Container>(raw);

                ContainerIdInput.Text = readJson.id;
                DisplayNameInput.Text = readJson.displayName;
                DescriptionInput.Text = readJson.description;

                ContentList.Items.Clear();
                contents.Clear();

                foreach (Content content in readJson.content)
                {
                    contents.Add(content);
                    ContentList.Items.Add(ContentList.Items.Count);
                }
            }
        }

        private void CategoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int referenceint = 1;

            if (selectedContent == null)
                return;

            if (CategoryDD.SelectedIndex == 0)
            {
                selectedReference = LootTables;
                referenceint = 0;
            }
            if (CategoryDD.SelectedIndex == 1)
            {
                selectedReference = Apparels;
            }
            if (CategoryDD.SelectedIndex == 2)
            {
                selectedReference = Weapons;
            }
            if (CategoryDD.SelectedIndex == 3)
            {
                selectedReference = Shields;
            }
            if (CategoryDD.SelectedIndex == 4)
            {
                selectedReference = Spells;
            }

            ReferenceDD.DataSource = selectedReference;

            selectedContent.reference = referenceint;
            referenceInput.Value = referenceint;
        }

        private void FileBTN_Click(object sender, EventArgs e)
        {
            if (Form1.saveLocation == null)
            {
                MessageBox.Show("Save Location can not be null");
                return;
            }

            //Generate JSON
            Container containerJson = new Container();

            containerJson.type = "ThunderRoad.ContainerData, Assembly-CSharp";

            containerJson.id = ContainerIdInput.Text;
            containerJson.displayName = DisplayNameInput.Text;
            containerJson.description = DescriptionInput.Text;
            containerJson.content = contents;

            string json = JsonConvert.SerializeObject(containerJson, Formatting.Indented);

            json = json.Replace("\"type\"", "\"$type\"");

            File.WriteAllText(Form1.saveLocation + @"\Container_" + containerJson.id + ".json", json);
        }
    }

    public class Container
    {
        public string type { get; set; }
        public string id { get; set; }
        public int version { get; set; } = 1;
        public bool exludeFromBuild { get; set; } = false;
        public string displayName { get; set; }
        public string description { get; set; }
        public List<Content> content { get; set; } = new List<Content>();
    }

    public class Content
    {
        public string referenceID { get; set; } = "Mage";
        public int reference { get; set; }
        public int quantity { get; set; } = 1;
        public List<CustomValues> customValues { get; set; } = new List<CustomValues>();
    }

    public class CustomValues
    {
        public CustomValues(string idref = null, string valueref = null)
        {
            id = idref;
            value = valueref;
        }

        public string id { get; set; }
        public string value { get; set; }
    }
}
