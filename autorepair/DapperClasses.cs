namespace autorepair
{
    class Brand_Repair
    {
        public string creator { get; set; }
        public string description { get; set; }
    }


    class Auto_Repair_Worker
    {
        public int id { get; set; }
        public string creator { get; set; }
        public string model { get; set; }
        public string duration { get; set; }
        public string worker_fio { get; set; }
    }


    class forOwners
    {
        public string fio { get; set; }
        public string adress { get; set; }
    }


    class forFixes
    {
        public string worker_fio { get; set; }
        public string end_date { get; set; }
    }
}
