using RDPCOMAPILib;
using System;
using System.Windows.Forms;

namespace AppCapture
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }
        
        private void RDPViewer1_Enter(object sender, EventArgs e)
        {

        }
        RDPSession rdp = new RDPSession();
        private void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }
        // Access to COM/firwall will prompt
        private void button1_Click(object sender, EventArgs e)
        {
            rdp.OnAttendeeConnected += Incoming;
            rdp.Open();
        }
        //connect
        private void button2_Click(object sender, EventArgs e)
        {
            IRDPSRAPIInvitation Invitation = rdp.Invitations.CreateInvitation("Trial", "MyGroup", "", 10);
            textBox1.Text = Invitation.ConnectionString;
        }
        //Share screen
        private void button4_Click(object sender, EventArgs e)
        {
            string Invitation = textBox1.Text;
            RDPViewer1.Connect(Invitation, "User1", "");
        }
        //stop sharing
        private void button5_Click(object sender, EventArgs e)
        {
            RDPViewer1.Disconnect();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
