using System.Numerics;

namespace ApiAlianza.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string sharedkey { get; set; }
        public string businessid { get; set; }
        public string email { get; set; }
        public Int64 phone { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }

    }
}
