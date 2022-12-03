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
