using SQLite.Net.Attributes;

namespace Arte
{
    public class Cliente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Fone { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Nome, Email, Fone);
        }
    }
}
