using SQLite.Net.Attributes;

namespace artesanato
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
		[MaxLength(300)]
		public string Produto { get; set; }

		[MaxLength(100)]
		public string Endereco { get; set; }

		public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Nome,  Fone, Produto, Email, Endereco);
        }
    }
}
