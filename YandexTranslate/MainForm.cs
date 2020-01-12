using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using YandexTranslate.BL;

namespace YandexTranslate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            yt = new YandexTranslator(Properties.Settings.Default.TokenYandexApi);            
        }

        YandexTranslator yt;

        private async void translateButton_Click(object sender, EventArgs e)
        {
            try
            {
                (sender as Button).Enabled = false;
                tBOutput.Text = await Task.Factory.StartNew(() => 
                        yt.Translate(tBSource.Text, $"{cBLangSorce.SelectedValue}-{cBLangOutput.SelectedValue}"));
                (sender as Button).Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var langs = DownloadLanguges();

            cBLangSorce.DataSource = langs;
            cBLangSorce.ValueMember = "Key";
            cBLangSorce.DisplayMember = "Value";

            cBLangOutput.DataSource = langs.Clone();
            cBLangOutput.ValueMember = "Key";
            cBLangOutput.DisplayMember = "Value";

            cBLangSorce.SelectedValue = "ru";
            cBLangOutput.SelectedValue = "en";
        }

        private KeyValuePair<string, string>[] DownloadLanguges()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "langs.json");
            if (File.Exists(path))
            {
                string file = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<KeyValuePair<string, string>[]>(file);
            }
            else
            {
                KeyValuePair<string, string>[] result = new KeyValuePair<string, string>[0];
                try
                {
                    result = yt.GetLangs("ru").AsEnumerable().OrderBy(x => x.Value).ToArray();
                    File.WriteAllText(path, JsonConvert.SerializeObject(result));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                return result;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            //var t1 = cBLangOutput.DataSource;
            //cBLangOutput.DataSource = cBLangSorce.DataSource;
            //cBLangSorce.DataSource = t1;
            (cBLangSorce.DataSource, cBLangOutput.DataSource) = (cBLangOutput.DataSource, cBLangSorce.DataSource);
            if (!string.IsNullOrEmpty(tBOutput.Text))
                (tBSource.Text, tBOutput.Text) = (tBOutput.Text, tBSource.Text);
        }
    }
}