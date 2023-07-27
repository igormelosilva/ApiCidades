namespace ApiCidades.Models
{
    public class City
    {
        //código, nome, estado, região, habitantes, data de fundação, altitude
        public int codigo { get; set; }
        public string nome { get; set; }
        public string estado { get; set; }
        public string regiao { get; set; }
        public int habitantes { get; set; }

        public DateTime data { get; set; }
        public int altitude { get; set; }


        
    }
}
