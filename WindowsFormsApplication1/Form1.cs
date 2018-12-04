using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client TClient = new WindowsFormsApplication1.ServiceReference1.Service1Client();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TClient.GetData(100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            
            RobotServices.RequestAMRActionArg[] AMRActionArgs = new RobotServices.RequestAMRActionArg[3];


            RobotServices.RequestAMRActionArg action1 = new RobotServices.RequestAMRActionArg();

            action1.ActionId = "11111111";
            action1.ActionType = 1;

             RobotServices.ActionArg[] ActionArg1 = new  RobotServices.ActionArg[2];
             RobotServices.ActionArg arg1 = new  RobotServices.ActionArg();
            arg1.ArgName = "amrDestination";

            arg1.ArgValue = "788,-380,90";
            ActionArg1[0] = arg1;

             RobotServices.ActionArg arg11 = new  RobotServices.ActionArg();

            arg11.ArgName = "amrSource";

            arg11.ArgValue = "0,0,0";
            ActionArg1[1] = arg11;

            action1.ActionArgs  = ActionArg1;

            AMRActionArgs[0] = action1;


             RobotServices.RequestAMRActionArg action3 = new  RobotServices.RequestAMRActionArg();

            action3.ActionId = "3333333";
            action3.ActionType = 2;

             RobotServices.ActionArg[] ActionArg3 = new  RobotServices.ActionArg[1];
             RobotServices.ActionArg arg3 = new  RobotServices.ActionArg();
            arg3.ArgName = "amrDestination";

            arg3.ArgValue = "788,0,90";
            ActionArg3[0] = arg3;
            action3.ActionArgs = ActionArg3;

            AMRActionArgs[1] = action3;





             RobotServices.RequestAMRActionArg action2 = new  RobotServices.RequestAMRActionArg();
            action2.ActionId = "22222222";
            action2.ActionType = 3;
             RobotServices.ActionArg[] args2 = new  RobotServices.ActionArg[4];

             RobotServices.ActionArg arg2 = new  RobotServices.ActionArg();
            arg2.ArgName = "amrDestination";
            arg2.ArgValue = "300,0,0";
            args2[0] = arg2;

             RobotServices.ActionArg arg21 = new  RobotServices.ActionArg();
            arg21.ArgName = "amrSource";
            arg21.ArgValue = "300,0,0";
            args2[1] = arg21;

             RobotServices.ActionArg arg22 = new  RobotServices.ActionArg();
            arg22.ArgName = "loadSource";
            arg22.ArgValue = "erack2";
            args2[2] = arg22;

             RobotServices.ActionArg arg23 = new  RobotServices.ActionArg();
            arg23.ArgName = "loadDestination";
            arg23.ArgValue = "robot2";
            args2[3] = arg23;

            action2.ActionArgs = args2;

            AMRActionArgs[2] = action2;

            // RobotServices.RequestAMRActionArg action3 = new  RobotServices.RequestAMRActionArg();
            //action3.ActionId = "33333333";
            //arg[2] = action3;
            client.RequestAMRAction(AMRActionArgs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //.Class1 cl = new TestToDiaodu.Class1();
            //String str =cl.SendData(2020);
            //MessageBox.Show(str);
        }
    }
}
