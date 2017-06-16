using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			label1.Text = @"File Path";
			textBox1.Text = Application.StartupPath + @"\xml.xml";
			textBox1.Multiline = true;
		
			this.Text = @"Czytanie kontrolki z xmla";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var dom = new XmlDocument();
				dom.Load(textBox1.Text);

				treeView1.Nodes.Clear();
				if (dom.DocumentElement == null) return;
				treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
				var tNode = treeView1.Nodes[0];

				AddNextNode(dom.DocumentElement, tNode);
			}
			catch (XmlException xmlEx)
			{
				MessageBox.Show(xmlEx.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private static string GetAttributeText(XmlNode inXmlNode, string name)
		{
			XmlAttribute attr = inXmlNode.Attributes?[name];
			return attr?.Value;
		}

		private void AddNextNode(XmlNode inXmlNode, TreeNode inTreeNode)
		{
			if (inXmlNode.HasChildNodes)
			{
				XmlNodeList nodeList = inXmlNode.ChildNodes;
				for (int i = 0; i <= nodeList.Count - 1; i++)
				{
					XmlNode xNode = inXmlNode.ChildNodes[i];
					string text = GetAttributeText(xNode, "name");
					if (string.IsNullOrEmpty(text))
					{
						text = xNode.Name;
					}
						
					inTreeNode.Nodes.Add(new TreeNode(text));
					TreeNode tNode = inTreeNode.Nodes[i];
					AddNextNode(xNode, tNode);
				}
			}
			else
			{
				string text = GetAttributeText(inXmlNode, "name");
				if (string.IsNullOrEmpty(text))
				{
					text = (inXmlNode.OuterXml).Trim();
				}

				if (inTreeNode.Text != text)
				{
					inTreeNode.Text = text;
				}
					
				inTreeNode.Nodes.Clear();
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}