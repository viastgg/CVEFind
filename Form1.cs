using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft;
using System.Drawing;
namespace CVEFind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string json="";
        private void search_Click(object sender, EventArgs e)
        {
            labelcat.Text = "Search Results for " + searchbox.Text;
            if (searchbox.Text == "")
            {
                labelcat.Text = "Please enter a search term.";
                MessageBox.Show("Please enter a search term !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                string url = "https://services.nvd.nist.gov/rest/json/cve/1.0/" + searchbox.Text;
                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                json = reader.ReadToEnd();
                Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(json);
                container_cve.Visible = true;
                ccvid.Visible = true;
                buttondetails.Visible = true;
                ccvid.Text = data.result.CVE_Items[0].cve.CVE_data_meta.ID;
                severityvalue.Text = " Severity Level : " + data.result.CVE_Items[0].impact.baseMetricV3.cvssV3.baseSeverity.ToString();
            // text color for severity level
            if (data.result.CVE_Items[0].impact.baseMetricV3.cvssV3.baseSeverity == "HIGH")
            {
                severityvalue.ForeColor = System.Drawing.Color.Red;
            }
            else if (data.result.CVE_Items[0].impact.baseMetricV3.cvssV3.baseSeverity == "MEDIUM")
            {
                severityvalue.ForeColor = System.Drawing.Color.Orange;
            }
            else if (data.result.CVE_Items[0].impact.baseMetricV3.cvssV3.baseSeverity == "LOW")
            {
                severityvalue.ForeColor = System.Drawing.Color.Green;
            }
            else if (data.result.CVE_Items[0].impact.baseMetricV3.cvssV3.baseSeverity == "CRITICAL")
            {
                severityvalue.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // if webrequest fails, show error message
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelcat_Click(object sender, EventArgs e)
        {

        }

        private void buttondetails_Click(object sender, EventArgs e)
        {
            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(json);
            richTextBox1.Text = "Vulnerability ID: " + data.result.CVE_Items[0].cve.CVE_data_meta.ID;
            richTextBox1.Text += "\nAssigner : " + data.result.CVE_Items[0].cve.CVE_data_meta.ASSIGNER;
            richTextBox1.Text += "\nPublished Date : " + data.result.CVE_data_timestamp;
            richTextBox1.Text += "\nReference URL: " + data.result.CVE_Items[0].cve.references.reference_data[0].url;
            richTextBox1.Text += "\nDescription: " + data.result.CVE_Items[0].cve.description.description_data[0].value;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Root data = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(json);
            saveccv.Title = "Save Vulnerability File";
            saveccv.Filter = "Text File (*.txt)|*.txt";
            saveccv.FileName = data.result.CVE_Items[0].cve.CVE_data_meta.ID;
            saveccv.ShowDialog();
            // write to file
            string path = saveccv.FileName;
            File.WriteAllText(path, richTextBox1.Text);
            MessageBox.Show("Operation Completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class BaseMetricV2
{
    public CvssV2 cvssV2 { get; set; }
    public string severity { get; set; }
    public double exploitabilityScore { get; set; }
    public double impactScore { get; set; }
    public bool acInsufInfo { get; set; }
    public bool obtainAllPrivilege { get; set; }
    public bool obtainUserPrivilege { get; set; }
    public bool obtainOtherPrivilege { get; set; }
    public bool userInteractionRequired { get; set; }
}

public class BaseMetricV3
{
    public CvssV3 cvssV3 { get; set; }
    public double exploitabilityScore { get; set; }
    public double impactScore { get; set; }
}

public class Configurations
{
    public string CVE_data_version { get; set; }
    public List<Node> nodes { get; set; }
}

public class CpeMatch
{
    public bool vulnerable { get; set; }
    public string cpe23Uri { get; set; }
    public List<object> cpe_name { get; set; }
}

public class Cve
{
    public string data_type { get; set; }
    public string data_format { get; set; }
    public string data_version { get; set; }
    public CVEDataMeta CVE_data_meta { get; set; }
    public Problemtype problemtype { get; set; }
    public References references { get; set; }
    public Description description { get; set; }
}

public class CVEDataMeta
{
    public string ID { get; set; }
    public string ASSIGNER { get; set; }
}

public class CVEItem
{
    public Cve cve { get; set; }
    public Configurations configurations { get; set; }
    public Impact impact { get; set; }
    public string publishedDate { get; set; }
    public string lastModifiedDate { get; set; }
}

public class CvssV2
{
    public string version { get; set; }
    public string vectorString { get; set; }
    public string accessVector { get; set; }
    public string accessComplexity { get; set; }
    public string authentication { get; set; }
    public string confidentialityImpact { get; set; }
    public string integrityImpact { get; set; }
    public string availabilityImpact { get; set; }
    public double baseScore { get; set; }
}

public class CvssV3
{
    public string version { get; set; }
    public string vectorString { get; set; }
    public string attackVector { get; set; }
    public string attackComplexity { get; set; }
    public string privilegesRequired { get; set; }
    public string userInteraction { get; set; }
    public string scope { get; set; }
    public string confidentialityImpact { get; set; }
    public string integrityImpact { get; set; }
    public string availabilityImpact { get; set; }
    public double baseScore { get; set; }
    public string baseSeverity { get; set; }
}

public class Description
{
    public string lang { get; set; }
    public string value { get; set; }
    public List<DescriptionDatum> description_data { get; set; }
}

public class DescriptionDatum
{
    public string lang { get; set; }
    public string value { get; set; }
}

public class Impact
{
    public BaseMetricV3 baseMetricV3 { get; set; }
    public BaseMetricV2 baseMetricV2 { get; set; }
}

public class Node
{
    public string @operator { get; set; }
    public List<object> children { get; set; }
    public List<CpeMatch> cpe_match { get; set; }
}

public class Problemtype
{
    public List<ProblemtypeDatum> problemtype_data { get; set; }
}

public class ProblemtypeDatum
{
    public List<Description> description { get; set; }
}

public class ReferenceDatum
{
    public string url { get; set; }
    public string name { get; set; }
    public string refsource { get; set; }
    public List<string> tags { get; set; }
}

public class References
{
    public List<ReferenceDatum> reference_data { get; set; }
}

public class Result
{
    public string CVE_data_type { get; set; }
    public string CVE_data_format { get; set; }
    public string CVE_data_version { get; set; }
    public string CVE_data_timestamp { get; set; }
    public List<CVEItem> CVE_Items { get; set; }
}

public class Root
{
    public int resultsPerPage { get; set; }
    public int startIndex { get; set; }
    public int totalResults { get; set; }
    public Result result { get; set; }
}


