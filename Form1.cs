using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using IpPbxCtiTest.WebReference;

namespace IpPbxCtiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region local Event
        private void axOmniCTIX1_AgentStatistics(object sender, AxOMNICTIXLib._DOmniCTIXEvents_AgentStatisticsEvent e)
        {
            Add2ListView("axOmniCTIX1_AgentStatistics N:" + e.sName
                        + " V:" + e.sValue);
        }

        private void axOmniCTIX1_agentStatus(object sender, AxOMNICTIXLib._DOmniCTIXEvents_agentStatusEvent e)
        {
            Add2ListView("axOmniCTIX1_agentStatus deviceAddress:" + e.deviceAddress + 
                " agentID:"+e.agentID+" status:" 
                        + e.status.ToString());
        }

        private void axOmniCTIX1_Answered(object sender, AxOMNICTIXLib._DOmniCTIXEvents_AnsweredEvent e)
        {
            Add2ListView("axOmniCTIX1_Answered enumCallID:" + e.enumCallID.ToString() 
                + " isAgentAnswer:" + e.isAgentAnswer.ToString());
        }

        private void axOmniCTIX1_ConnectionBroken(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_ConnectionBroken");
        }

        private void axOmniCTIX1_ConnectionReady(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_ConnectionReady");
        }

        private void axOmniCTIX1_DestBusy(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_DestBusy");
        }

        private void axOmniCTIX1_DeviceStatus(object sender, AxOMNICTIXLib._DOmniCTIXEvents_DeviceStatusEvent e)
        {
            Add2ListView("axOmniCTIX1_DeviceStatus deviceAddress:" 
                + e.deviceAddress + " isIdle:" + e.isIdle.ToString());
        }

        private void axOmniCTIX1_InboundCall(object sender, AxOMNICTIXLib._DOmniCTIXEvents_InboundCallEvent e)
        {
            Add2ListView("axOmniCTIX1_InboundCall callType:" + e.callType + " currentCalledParty:" + e.currentCalledParty 
                + " currentCallingParty:" + e.currentCallingParty
                        + " originalCalledParty:" + e.originalCalledParty 
                        +" originalCallingParty:"+ e.originalCallingParty
                        + " enumCallID:"+e.enumCallID.ToString());
        }

        private void axOmniCTIX1_LoggedIn(object sender, AxOMNICTIXLib._DOmniCTIXEvents_LoggedInEvent e)
        {
            Add2ListView("axOmniCTIX1_LoggedIn isMonitor:" + e.isMonitor.ToString());
        }

        private void axOmniCTIX1_DialTone(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_DialTone");
        }

        private void axOmniCTIX1_LoggedOut(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_LoggedOut");
        }

        private void axOmniCTIX1_RingBack(object sender, AxOMNICTIXLib._DOmniCTIXEvents_RingBackEvent e)
        {
            Add2ListView("axOmniCTIX1_RingBack currentCalledParty:" + e.currentCalledParty
            + " currentCallingParty:"+e.currentCallingParty
            + " enumCallID:" + e.enumCallID.ToString());
        }

        private void axOmniCTIX1_TextMessage(object sender, AxOMNICTIXLib._DOmniCTIXEvents_TextMessageEvent e)
        {
            Add2ListView("axOmniCTIX1_TextMessage agentID:" + e.agentID
            + " address:" + e.address + " msg:"+e.tmessage);
        }

        private void axOmniCTIX1_Transfered(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_Transfered");
            
        }
        private void axOmniCTIX1_Conferenced(object sender, EventArgs e)
        {
            Add2ListView("axOmniCTIX1_Conferenced");
        }
        private void axOmniCTIX1_WaitforService(object sender, AxOMNICTIXLib._DOmniCTIXEvents_WaitforServiceEvent e)
        {
            Add2ListView("axOmniCTIX1_WaitforService");
        }

        private void axOmniCTIX1_AgentStatusCNGed(object sender, AxOMNICTIXLib._DOmniCTIXEvents_AgentStatusCNGedEvent e)
        {
            Add2ListView("axOmniCTIX1_AgentStatusCNGed local agentStatus:" + e.agentStatus.ToString());
        }

        private void axOmniCTIX1_CallIdle(object sender, AxOMNICTIXLib._DOmniCTIXEvents_CallIdleEvent e)
        {
            Add2ListView("axOmniCTIX1_CallIdle enumCallID:" + e.enumCallID.ToString() 
                + " isAgentHangupFirst:" + e.isAgentHangupFirst.ToString());
        }
        #endregion

        #region remote event
        private void axOmniCTIX1_MAnswered(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MAnsweredEvent e)
        {

        }

        private void axOmniCTIX1_MCallIdle(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MCallIdleEvent e)
        {

        }

        private void axOmniCTIX1_MConferenced(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MConferencedEvent e)
        {

        }

        private void axOmniCTIX1_MDialTone(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MDialToneEvent e)
        {

        }

        private void axOmniCTIX1_MInboundCall(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MInboundCallEvent e)
        {
            Add2ListView("axOmniCTIX1_MInboundCall callType:" + e.callType + " currentCalledParty:" + e.currentCalledParty
                + " currentCallingParty:" + e.currentCallingParty
                        + " originalCalledParty:" + e.originalCalledParty
                        + " originalCallingParty:" + e.originalCallingParty
                        + " enumCallID:" + e.enumCallID.ToString());
        }

        private void axOmniCTIX1_MTextMessage(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MTextMessageEvent e)
        {

        }

        private void axOmniCTIX1_MTransfered(object sender, AxOMNICTIXLib._DOmniCTIXEvents_MTransferedEvent e)
        {

        }
        #endregion

        #region methods
        private delegate void Delegate_Add2ListView(string  msg);
        private void Add2ListView(string msg)
        {
            Delegate_Add2ListView del = new Delegate_Add2ListView(add2ListBox);
            base.Invoke(del,msg);
        }
        private void add2ListBox(string msg)
        {
            this.listBox1.Items.Insert(0, msg);
        }
        #endregion

        /// <summary>
        /// connect cti server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string ip =ConfigurationManager.AppSettings["IP"];
            int port =int.Parse(ConfigurationManager.AppSettings["Port"]);
            if (axOmniCTIX1.Connect(ip, port))
            {
                //TODO
                Add2ListView("connect succ");
            }
            else
            {
                MessageBox.Show("connect failed");
            }
        }

        /// <summary>
        /// disconnect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            axOmniCTIX1.Disconnect();
            //if (!axOmniCTIX1.Disconnect())
            //{
            //    MessageBox.Show("disconnect failed");
            //}
            //else
            //{
            //    add2ListBox("disconnect succ");
            //}
        }
        /// <summary>
        /// login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string agentID =ConfigurationManager.AppSettings["AgentID"];
            string deviceAddress=ConfigurationManager.AppSettings["DeviceAddress"];
            this.Text = agentID + "/" + deviceAddress;
            string password =ConfigurationManager.AppSettings["PassWord"];
            if (axOmniCTIX1.Login(agentID, "", deviceAddress, password))
            {
                //TODO
                Add2ListView(agentID + " login succ");
            }
            else
            {
                MessageBox.Show(agentID+" login failed");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string agentID = ConfigurationManager.AppSettings["AgentID"];            
            if (axOmniCTIX1.Logout())
            {
                //TODO
                Add2ListView(agentID + " logout succ");
            }
            else
            {
                MessageBox.Show(agentID + " logout failed");
            }
        }
        /// <summary>
        /// make call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.MakeCall(textBox1.Text, ""))
            {
                MessageBox.Show("makecall failed");
            }
            else
            {
                Add2ListView("makecall succ");
            }
        }

        /// <summary>
        /// transfer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.TransferCall(textBox2.Text, ""))
            {
                MessageBox.Show("transfer failed");
            }
            else
            {
                Add2ListView("transfer succ");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //if (!axOmniCTIX1.ForemanExtend())
            //{
            //    MessageBox.Show("ForemanExtend failed");
            //}
            //else
            //{
            //    Add2ListView("ForemanExtend succ");
            //}
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //if (!axOmniCTIX1.ForemanExtendForNBX())
            //{
            //    MessageBox.Show("ForemanExtendForNBX failed");
            //}
            //else
            //{
            //    Add2ListView("ForemanExtendForNBX succ");
            //}
        }
        /// <summary>
        /// hangup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.HangUp())
            {
                MessageBox.Show("hangup failed");
            }
            else
            {
                Add2ListView("hangup succ");
            }
        }

        /// <summary>
        /// conference call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            if (axOmniCTIX1.ConferenceCall(textBox5.Text,""))
            {
                Add2ListView("conference succ");
            }
            else
            {
                MessageBox.Show("conference failed");
                
            }
        }

        /// <summary>
        /// answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.AnswerCall())
            {
                MessageBox.Show("answer failed");
            }
            else
            {
                Add2ListView("answer succ");
            }
        }

        /// <summary>
        /// cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.Cancel())
            {
                MessageBox.Show("cancel failed");
            }
            else
            {
                Add2ListView("cancel succ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.KickOut(textBox1.Text))
            {
                MessageBox.Show("kickout failed");
            }
            else
            {
                Add2ListView("kickout succ");
            }
        }

        /// <summary>
        /// intrude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.ForemanExtend(2,textBox9.Text,textBox7.Text,""))
            {
                MessageBox.Show("强插 failed");
            }
            else
            {
                Add2ListView("强插 succ");
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.ForemanExtend(1, textBox9.Text, textBox7.Text, ""))
            {
                MessageBox.Show("监听 failed");
            }
            else
            {
                Add2ListView("监听 succ");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.ForemanExtend(3, textBox9.Text, textBox7.Text, textBox10.Text))
            {
                MessageBox.Show("强转 failed");
            }
            else
            {
                Add2ListView("强转 succ");
            }
        }
        /// <summary>
        /// send msg 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.SendTXTMessage(textBox4.Text,textBox3.Text))
            {
                MessageBox.Show("sendmsg failed");
            }
            else
            {
                Add2ListView("sendmsg succ");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no fits method found");
            //if (!axOmniCTIX1.(textBox4.Text, textBox3.Text))
            //{
            //    MessageBox.Show("sendmsg failed");
            //}
            //else
            //{
            //    Add2ListView("sendmsg succ");
            //}
        }

        /// <summary>
        /// set ready
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            axOmniCTIX1.ChangeAgentStatus(1, "ready");
        }

        /// <summary>
        /// set work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i have no idea what state it should be!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axOmniCTIX1.ChangeAgentStatus(3, "notready");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int status = axOmniCTIX1.GetStatus();
            Add2ListView("new status:" + status.ToString());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            add2ListBox("IsMonitor:" + axOmniCTIX1.IsMonitor().ToString());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            axOmniCTIX1.StartMonitor();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            axOmniCTIX1.StopMonitor();
        }

        
        private void button21_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.UnholdCall())
            {
                MessageBox.Show("unhold failed");
            }
            else
            {
                Add2ListView("unhold succ");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RegOcx();
        }
        private void RegOcx()
        {
            try
            {
                string[] ocxs = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Lib\\", "*.ocx");
                for (int i = 0; i < ocxs.Length; i++)
                {
                    string ocxPath = ocxs[i];
                    System.Diagnostics.Process.Start("regsvr32.exe","-s \""+ocxPath+"\"");
                }

            }
            catch { }

        }
        private void axOmniCTIX1_CallDetail(object sender, AxOMNICTIXLib._DOmniCTIXEvents_CallDetailEvent e)
        {
            this.Add2ListView("CallDetail agentID:" + e.agentID+
                 " st:"+e.beginTime+
                 " pt:"+e.pickupTime+
                 " et:"+e.endTime+
                 " calledNumber:"+e.calledNumber+
                 " callingNumber:"+e.callingNumber+
                 " isInbound:"+e.isInbound.ToString()+
                " isAgentHangupFirst:"+e.isAgentHangupFirst.ToString());
        }
        

        /// <summary>
        /// redirect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button26_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.RedirectCall(textBox6.Text))
            {
                MessageBox.Show("redirect failed");
            }
            else
            {
                Add2ListView("redirect succ");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!axOmniCTIX1.HoldCall())
            {
                MessageBox.Show("hold failed");
            }
            else
            {
                Add2ListView("hold succ");
            }
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            String info = service.GetRecordFileInfo(textBox8.Text);
            MessageBox.Show(info);
        }

        

       

       

        

        




        
    }
}