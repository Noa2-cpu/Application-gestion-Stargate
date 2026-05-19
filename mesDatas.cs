using System.Data;

namespace SAE24
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();

        public static DataSet DsGlobal { get { return MesDatas.dsGlobal; } }

    }
}
