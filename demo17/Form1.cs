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
using System.Xml;

namespace demo17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //注意：所有节点的创建都是在文档中创建的 文档名.creatElement

            //1.创建XML文档对象
            //2.引进命名空间
            XmlDocument doc = new XmlDocument(); //相等于创建了一页白纸

            //3.创建第一行描述信息，并添加到doc文档中
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);//这里是xml文件中的第一行即描述信息行 1.0版本  utf-8解码格式
            doc.AppendChild(declaration);  //将信息添加到doc文档中
           
            //4.创建第一个根节点
            XmlElement BooksNode = doc.CreateElement("Books");
            doc.AppendChild(BooksNode);  //将信息添加到doc文档中

            //5.创建根节点的子节点
            XmlElement bookNode = doc.CreateElement("book");
            BooksNode.AppendChild(bookNode); //将节点添加到子节点中

            //6.创建根节点的子节点的子节点
            XmlElement NameNode1 = doc.CreateElement("Name");
            NameNode1.InnerText = "《水浒传》";
            bookNode.AppendChild(NameNode1);

            XmlElement PriceNode1 = doc.CreateElement("Price");
            PriceNode1.InnerText = "20";
            bookNode.AppendChild(PriceNode1);

            XmlElement DesNode1 = doc.CreateElement("Des");
            DesNode1.InnerText = "义薄云天";
            bookNode.AppendChild(DesNode1);

            //************

            XmlElement bookNode2 = doc.CreateElement("book");
            BooksNode.AppendChild(bookNode2); //将节点添加到子节点中

            //6.创建根节点的子节点的子节点
            XmlElement NameNode2 = doc.CreateElement("Name");
            NameNode2.InnerText = "《红楼梦》";
            bookNode2.AppendChild(NameNode2);

            XmlElement PriceNode2 = doc.CreateElement("Price");
            PriceNode2.InnerText = "20";
            bookNode2.AppendChild(PriceNode2);

            XmlElement DesNode2 = doc.CreateElement("Des");
            DesNode2.InnerText = "儿女情长";
            bookNode2.AppendChild(DesNode2);

            //7.保存
            doc.Save("Books.xml");
            MessageBox.Show("保存成功");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument(); //相等于创建了一页白纸

           
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);//这里是xml文件中的第一行即描述信息行 1.0版本  utf-8解码格式
            doc.AppendChild(declaration);  //将信息添加到doc文档中
            
            XmlElement BooksNode = doc.CreateElement("Books");
            doc.AppendChild(BooksNode);  //将信息添加到doc文档中
            
            XmlElement OverrideNode = doc.CreateElement("CustomerName");
            OverrideNode.InnerText = "信息技术";
            BooksNode.AppendChild(OverrideNode);  //将信息添加到doc文档中

            XmlElement OverrideNode1 = doc.CreateElement("Count");
            BooksNode.AppendChild(OverrideNode1);  //将信息添加到doc文档中

            XmlElement items1 = doc.CreateElement("Item1");
            items1.SetAttribute("name", "zyx");
            items1.SetAttribute("age", "28");
            OverrideNode1.AppendChild(items1);  //将信息添加到doc文档中

            XmlElement items2 = doc.CreateElement("Item1");
            items2.SetAttribute("name", "czq");
            items2.SetAttribute("age", "22");
            OverrideNode1.AppendChild(items2);  //将信息添加到doc文档中
            doc.Save("SaveBoo.xml");
            MessageBox.Show("写入成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();//创建文档对象
            XmlElement books = null; //文档第一行
            XmlElement book1 = null; //根节点

            if(File.Exists("Books.xml"))//判断Books.xml是否存在
            {
                doc.Load("Books.xml");
                books = doc.DocumentElement; 
            }
            else
            {
                XmlDeclaration newBooks = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(newBooks);
                //创建根节点
                book1 = doc.CreateElement("Books");
                doc.AppendChild(book1);
            }

            //如果文件已存在 追加内容 没有创建新的内容
            XmlElement book11 = doc.CreateElement("book");
            book1.AppendChild(book11);

            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "<西游记>";
            book11.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "25";
            book11.AppendChild(price1);

            XmlElement dec1 = doc.CreateElement("Des");
            dec1.InnerText = "妖魔鬼怪";
            book11.AppendChild(dec1);

            doc.Save("Books.xml");
            MessageBox.Show("保存成功");
        }

        private void getContent_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            //加载读取的XML
            doc.Load("Books.xml");

            //获取根节点
            XmlElement Node = doc.DocumentElement;

            //获取根节点的子节点,返回字节集合
            XmlNodeList node = Node.ChildNodes;
            foreach (XmlNode item in node)
            {
                listNodes.AppendText(item.InnerText+"\n");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SaveBoo.xml");

            //根据节点查找属性
            XmlNodeList node = doc.SelectNodes("/Books/Count/Item1");//一个节点一个节点找
            foreach (XmlNode item in node)
            {
                listNodes.AppendText(item.Attributes["name"].Value);
                listNodes.AppendText(item.Attributes["age"].Value );
                listNodes.AppendText("\n");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SaveBoo.xml");

            //获取要删除的节点
            XmlNode nodes = doc.SelectSingleNode("/Books/Count");//删除count节点里面的所有东西
            nodes.RemoveAll();
            doc.Save("SaveBoo.xml");
        }
    }
}
