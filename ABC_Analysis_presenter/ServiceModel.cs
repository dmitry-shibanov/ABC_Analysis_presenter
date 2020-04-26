

namespace ABC_Analysis_presenter
{
    class ServiceModel
    {
        public string name = "";
        public int cost = 0;
        public int count = 0;
        public int earn = 0;
        public float partEarn = 0f;
        public float partCount = 0f;
        public float sumPartCount = 0f;
        public float sumPartEarn = 0f;
        public Groups[] groups = new Groups[2] { Groups.A, Groups.X };
      

        public ServiceModel(string name, int cost, int count, int earn)
        {
            this.name = name;
            this.cost = cost;
            this.count = count;
            this.earn = earn;
        }

        public ServiceModel() { }

        public enum Groups { A,B,C,X,Y,Z }
    }
}
