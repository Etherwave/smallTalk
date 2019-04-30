using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.PeerToPeer;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallTalk
{
    public partial class Form1 : Form
    {
        public IPAddress[] ips;
        public int port = 8888;
        PeerNameRegistration resourceNameReg;
        public string lastInfoTime;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox_Name.Text = "Bob";
            timer1.Interval = 500;//毫秒为单位
            timer1.Enabled = true;
            lastInfoTime = "";
            Init();
        }

        public void Init()
        {
            ips = Dns.GetHostAddresses("");
            port = new Random().Next(48000, 50000);
            this.resourceNameReg = new PeerNameRegistration();
            register();
            // 将资源名注册到云中
            // 具体资源名的结构在博客有介绍

            resourceNameReg.Start();

        }

        public void register()
        {
            PeerName resourceName = new PeerName(textBox_Name.Text, PeerNameType.Unsecured);
            // 用指定的名称和端口号初始化PeerNameRegistration类的实例
            resourceNameReg = new PeerNameRegistration(resourceName, this.port);
            // 设置在云中注册的对等名对象的其他信息的注释
            resourceNameReg.Comment = DateTime.Now.ToShortTimeString()+":"+DateTime.Now.Second.ToString();
            // 设置PeerNameRegistration对象的应用程序定义的二进制数据
            resourceNameReg.Data = Encoding.UTF8.GetBytes(textBox_talk.Text.Length == 0 ? " " : textBox_talk.Text);
            // 在云中注册PeerName(对等名)
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox_talk.Text == "")
            {
                return;
            }
            resourceNameReg.Stop();
            register();
            resourceNameReg.Start();
            
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(resourceNameReg.Comment);
            item.SubItems.Add(textBox_Name.Text);
            item.SubItems.Add(textBox_talk.Text);
            listView1.Items.Add(item);

            textBox_talk.Text = "";
            
        }

        private void TextBox_talk_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    Button1_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void Search()
        {
            if (textBox_Name2.Text == "")
            {
                return;
            }

            // 初始化要搜索的资源名
            PeerName searchSeed = new PeerName("0." + textBox_Name2.Text);
            // PeerNameResolver类是将节点名解析为PeerNameRecord的值（即将通过资源名来查找资源名所在的地址,包括IP地址和端口号）
            // PeerNameRecord用来定于云中的各个节点
            PeerNameResolver myresolver = new PeerNameResolver();

            // PeerNameRecordCollection表示PeerNameRecord元素的容器
            // Resolve方法是同步的完成解析
            // 使用同步方法可能会出现界面“假死”现象
            // 解决界面假死现象可以采用多线程或异步的方式
            // 关于多线程的知识可以参考本人博客中多线程系列我前面UDP编程中有所使用
            // 在这里就不列出多线程的使用了，朋友可以自己实现，如果有问题可以留言给我一起讨论
            PeerNameRecordCollection recordCollection = myresolver.Resolve(searchSeed);
            if (recordCollection.Count==0) return;
            PeerNameRecord record = recordCollection[0];
            ListViewItem item = new ListViewItem();
            string t = record.Comment.ToString();
            if(this.lastInfoTime!=t)
            {
                this.lastInfoTime = t;
                item.SubItems.Add(record.Comment.ToString());
                item.SubItems.Add(record.PeerName.ToString().Substring(2));
                item.SubItems.Add(Encoding.UTF8.GetString(record.Data));
                listView1.Items.Add(item);
            }
        }

        public delegate void work();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Invoke(new work(this.Search));
            //Thread thread = new Thread(this.Search);
            //thread.Start();
            //Search();
        }
    }
}
