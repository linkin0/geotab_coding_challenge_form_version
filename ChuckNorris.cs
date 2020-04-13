using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JokeGenerator {
    public partial class FormChuckNorris : Form {

        private bool isDarkMode = false;

        private const String DefaultNameVallue  = "chuck norris";
        private const String ChuckNorisJokesURL = "https://api.chucknorris.io";
        private const String RandomNamesSiteURL = "https://namey.muffinlabs.com/name.json?with_surname=true";
        private const String ChuckNorrisIoImage = "https://assets.chucknorris.host/img/avatar/chuck-norris.png";
        private const String RandomCategorySelection = "random";

        private const String ChuckNorrisRandomJokesResource = "jokes/random";
        private const String ChuckNorrisCategoryResource = "jokes/categories";

        static private String[] results = new string[50]; // receive the results to out put to the screen
        static private String name; // will contain the random name produced

        private List<String> categories;

        private int resultLimit  = 20;

        private static IJsonFeed _jsonFeed; // handle to JsonFeed class via IJsonFeed interface

        public FormChuckNorris() {
            InitializeComponent();

            InitializeFields();
            InitializeImages();
        }

        private void buttonGetJokes_Click(object sender, EventArgs e) {
            GetRandomJokes((String)comboBoxCategories.SelectedItem, (int)comboBoxNumberOfJokes.SelectedItem);

            StringBuilder sb = new StringBuilder();

            foreach(String item in results) {
                sb.AppendLine(item + "\n");
            }

            richTextBoxJokeDisplay.Text = sb.ToString();
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e) {                       
        }

        private void comboBoxNumberOfJokes_SelectedIndexChanged(object sender, EventArgs e) {                       
        }

        /// <summary>
		/// Get a random joke(s) wrapper method, retrieves chuck norris jokes.
		/// </summary>
		/// <param name="category">The category of Chuck Norris jokes we want.</param>
        /// <param name="numberOfResults">The number of Chuck Norris jokes we want.</param>		
        private static void GetRandomJokes(string category, int numberOfResults) {

            var args = new Dictionary<String, String>();

            if(category != null)
                if(GetCategories().Contains(category))
                    args.Add("category", category);

            if(name != null && name.ToLower() != DefaultNameVallue)
                args.Add("name", name);

            if(category == null && name == null)
                args = null;

            _jsonFeed = new JsonFeed(ChuckNorisJokesURL, numberOfResults, "value");
            results = _jsonFeed.GetJSONValuesList(ChuckNorrisRandomJokesResource, args).ToArray();
        }

        /// <summary>
        /// Get the categories wrapper method, retrieves the categories of Chuck Norris jokes.
        /// </summary>
        /// <returns>Returns a string list of categories for Chuck Norris jokes.</returns>
        private static List<String> GetCategories() {

            _jsonFeed = new JsonFeed(ChuckNorisJokesURL, 0);
            List<String> categories = _jsonFeed.GetJSONValuesList(ChuckNorrisCategoryResource);
            results = categories.ToArray();

            return categories;
        }

        /// <summary>
        /// Get the name wrapper method, retrieve a random name to replace Chuck Norris with.
        /// </summary>		
        private static void GetNames() {

            _jsonFeed = new JsonFeed(RandomNamesSiteURL, 0);

            name = _jsonFeed.GetJSONValuesList()[0];
        }

        /// <summary>
        /// Initialize form fields.
        /// </summary>
        private void InitializeFields() {

            categories = GetCategories();

            comboBoxCategories.Items.Add(RandomCategorySelection);
            foreach(String item in categories) {

                  comboBoxCategories.Items.Add(item);              
            }

            for(int i = 0;i < resultLimit; i++) {

                comboBoxNumberOfJokes.Items.Add(i + 1);
            }

            comboBoxCategories.SelectedIndex = 0;
            comboBoxNumberOfJokes.SelectedIndex = 0;
        }

        /// <summary>
        /// Apply the Chuck Norris image from api.chucknorris.io ot the picture box.
        /// </summary>
        private void InitializeImages() {
            pictureBoxChuckNorris.Load(ChuckNorrisIoImage);
        }


        /// <summary>
        /// Get a random name and put it in the name text box.
        /// </summary>
        private void buttonGenerateRandomName_Click(object sender, EventArgs e) {
            GetNames();
            textBoxName.Text = name;
        }

        /// <summary>
        /// If someone edits the name text field by hand, save text in name.
        /// </summary>
        private void textBoxName_TextChanged(object sender, EventArgs e) {
            name = textBoxName.Text;
        }

        /// <summary>
        /// Toggle to light mode.
        /// </summary>
        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e) {
            ResetAllControlsBackColor(this, sender);
        }


        /// <summary>
        /// Toggle to dark mode.
        /// </summary>
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e) {
            ResetAllControlsBackColor(this, sender);
        }

        /// <summary>
        /// Toggle between light and dark modes of the UI and recursivley apply the colour changes
        /// to all the existing controls on the Chuck Norris form.
        /// </summary>
        /// <param name="control">Handle to the from.</param>
        /// <param name="sender">Handle to the the light or dark menu option handles.</param>
        private void ResetAllControlsBackColor(Control control, object sender) {

            bool currentMode = isDarkMode;

            Color text = SystemColors.ControlText;
            Color background = SystemColors.Control;

            if(sender == toolStripMenuItemLightMode) {

                isDarkMode = false;
                richTextBoxJokeDisplay.ForeColor = SystemColors.ControlText;
                richTextBoxJokeDisplay.BackColor = SystemColors.Control;
            }else if(sender == ToolStripMenuItemDarkMode) {

                text = Color.White;
                background = Color.Black;
                richTextBoxJokeDisplay.ForeColor = text;
                richTextBoxJokeDisplay.BackColor = background;
                isDarkMode = true;
            }

            if(currentMode != isDarkMode) {
                control.BackColor = background;
                control.ForeColor = text;
                if(control.HasChildren) {
                    // Recursively call this method for each child control.
                    foreach(Control childControl in control.Controls) {
                        ResetAllControlsBackColor(childControl, sender);
                    }
                }
                buttonGenerateRandomName.ForeColor = Color.Black;
                buttonGetJokes.ForeColor = Color.Black;
            }           
        }
    }
}
