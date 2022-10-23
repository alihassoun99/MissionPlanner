namespace MissionPlanner
{
    public class Program : MissionPlanner.Plugin.Plugin
    {

        public override string Name
        {
            get { return "GraphiquePluginn"; }
        }


        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Ali Hassoun"; }
        }

        public override bool Init()
        {
            this.testloop();
            return true;
        }

        public override bool Loaded()
        {
            Form1 plug = new Form1();
            plug.Activate();
            plug.Show();
            return true;
        }

        public override bool Loop()
        {

            CurrentState state = new CurrentState();
            short valeur_capteur_charge = state.CapteurCharge;
            float val = (float)CurrentState._capteurcharge;
            // Console.WriteLine("TEST  Loop   valeur capteur de charge  val = : " + valeur_capteur_charge.ToString());

            //Int32 calculeResult = state.ResulatCalcule;
            //Console.WriteLine("TEST  Loop   valeur calculeResult  val = : " + calculeResult.ToString());




            //float val1 = (float)CurrentState._capteurcharge; 
            //Console.WriteLine("TEST valeur capteur de charge  : " + val1.ToString());

            //float val2 = (float)CurrentState._capteurrpm1; 
            //Console.WriteLine("TEST valeur capteur rpm  1 : " + val2.ToString());
            //float val3 = (float)CurrentState._capteurrpm2; 
            //Console.WriteLine("TEST valeur capteur rpm  2 : " + val3.ToString());
            //float val4 = (float)CurrentState._capteurrpm3; 
            //Console.WriteLine("TEST valeur capteur rpm  3 : " + val4.ToString());
            //float val5 = (float)CurrentState._capteurrpm4; 
            //Console.WriteLine("TEST valeur capteur rpm  4 : " + val5.ToString());
            //Console.WriteLine(MainV2.comPort.MAV.cs.sideslip);

            return true;
        }


        public bool testloop()
        {

            return true;
        }

        public override bool Exit()
        {
            return true;
        }


    }
}
