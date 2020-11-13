using System;
using System.Windows.Forms;
using System.Xml;

namespace PIPlanner
{
    public partial class frmMain : Form
    {
        XmlDocument xmlPlanets = null;
        XmlDocument xmlResources = null;
        XmlDocument xmlProducts = null;
        XmlNodeList xnlPlanets = null;
        XmlNodeList xnlResources = null;
        XmlNodeList xnlProducts = null;

        void LoadPlanets()
        {
            xmlPlanets = new XmlDocument();
            xmlPlanets.Load("data/planets.xml");
            xnlPlanets = xmlPlanets.GetElementsByTagName("Planets");
            for (int i = 0; i < xnlPlanets[0].ChildNodes.Count; i++)
            {
                cbPlanetType.Items.Add(xnlPlanets[0].ChildNodes[i].ChildNodes[0].InnerText);
            }
        }

        void LoadResources()
        {
            xmlResources = new XmlDocument();
            xmlResources.Load("data/resources.xml");
            xnlResources = xmlResources.GetElementsByTagName("Resources");
            for (int i = 0; i < xnlResources[0].ChildNodes.Count; i++)
            {
                cbResourceType.Items.Add(xnlResources[0].ChildNodes[i].ChildNodes[0].InnerText);
            }
        }

        void LoadProducts()
        {
            xmlProducts = new XmlDocument();
            xmlProducts.Load("data/products.xml");
            xnlProducts = xmlProducts.GetElementsByTagName("Products");
            for (int i = 0; i < xnlProducts[0].ChildNodes.Count; i++)
            {
                cbProductType.Items.Add(xnlProducts[0].ChildNodes[i].ChildNodes[0].InnerText);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadPlanets();
            LoadResources();
            LoadProducts();
            cbPlanetType.SelectedIndex = 0;
            cbResourceType.SelectedIndex = 0;
            cbProductType.SelectedIndex = 0;
        }

        private void cbPlanetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAvailableResources.Items.Clear();
            rtbPlanetDesc.Clear();
            rtbPlanetDesc.Text = xnlPlanets[0].ChildNodes[cbPlanetType.SelectedIndex].ChildNodes[1].InnerText;
            pbImage.Load(xnlPlanets[0].ChildNodes[cbPlanetType.SelectedIndex].ChildNodes[2].InnerText);

            for (int i = 3; i < 8; i++)
            {
                lbAvailableResources.Items.Add(xnlPlanets[0].ChildNodes[cbPlanetType.SelectedIndex].ChildNodes[i].InnerText);
            }
        }

        private void cbResourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbResourceVolume.Clear();
            rtbResourceDesc.Clear();
            lbResourceUsed.Items.Clear();

            tbResourceVolume.Text = xnlResources[0].ChildNodes[cbResourceType.SelectedIndex].ChildNodes[1].InnerText;
            rtbResourceDesc.Text = xnlResources[0].ChildNodes[cbResourceType.SelectedIndex].ChildNodes[2].InnerText;

            for (int i = 0; i < xnlProducts[0].ChildNodes.Count; i++)
            {
                for (int x = 3; x < 6; x++)
                {
                    if (xnlProducts[0].ChildNodes[i].ChildNodes[x].InnerText == cbResourceType.Text)
                    {
                        lbResourceUsed.Items.Add(xnlProducts[0].ChildNodes[i].ChildNodes[0].InnerText);
                        break;
                    }
                }
            }
        }

        private void lbAvailableResources_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < cbResourceType.Items.Count; i++)
            {
                if (cbResourceType.Items[i].ToString() == lbAvailableResources.SelectedItem.ToString())
                {
                    tcMain.SelectedIndex = 1;
                    cbResourceType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbReqComponents.Items.Clear();
            tbProductTier.Clear();
            tbProductVolume.Clear();
            rtbProductDesc.Clear();
            lbProductUsed.Items.Clear();

            tbProductTier.Text = xnlProducts[0].ChildNodes[cbProductType.SelectedIndex].ChildNodes[1].InnerText;
            tbProductVolume.Text = xnlProducts[0].ChildNodes[cbProductType.SelectedIndex].ChildNodes[2].InnerText;

            for (int i = 3; i < 6; i++)
            {
                lbReqComponents.Items.Add(xnlProducts[0].ChildNodes[cbProductType.SelectedIndex].ChildNodes[i].InnerText);
            }

            rtbProductDesc.Text = xnlProducts[0].ChildNodes[cbProductType.SelectedIndex].ChildNodes[6].InnerText;

            for (int i = 0; i < xnlProducts[0].ChildNodes.Count; i++)
            {
                for (int x = 3; x < 6; x++)
                {
                    if (xnlProducts[0].ChildNodes[i].ChildNodes[x].InnerText == cbProductType.Text)
                    {
                        lbProductUsed.Items.Add(xnlProducts[0].ChildNodes[i].ChildNodes[0].InnerText);
                        break;
                    }
                }
            }
        }

        private void lbResourceUsed_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < cbProductType.Items.Count; i++)
            {
                if (cbProductType.Items[i].ToString() == lbResourceUsed.SelectedItem.ToString())
                {
                    tcMain.SelectedIndex = 2;
                    cbProductType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void lbProductUsed_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < cbProductType.Items.Count; i++)
            {
                if (cbProductType.Items[i].ToString() == lbProductUsed.SelectedItem.ToString())
                {
                    cbProductType.SelectedIndex = i;
                    break;
                }
            }
        }

        private void lbReqComponents_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < cbProductType.Items.Count; i++)
            {
                if (cbProductType.Items[i].ToString() == lbReqComponents.SelectedItem.ToString())
                {
                    cbProductType.SelectedIndex = i;
                    break;
                }
                else if ((i < cbResourceType.Items.Count) && (cbResourceType.Items[i].ToString() == lbReqComponents.SelectedItem.ToString()))
                {
                    tcMain.SelectedIndex = 1;
                    cbResourceType.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
