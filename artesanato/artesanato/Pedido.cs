﻿using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;

namespace Arte
{
    class Pedido
    {
       
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Produto { get; set; }
       
        public decimal Valor { get; set; }
        
        public DateTime DataEntrega { get; set; }
        
        [ForeignKey(typeof(Cliente))]
        public int ClienteId { get; set; }

        [OneToOne]
        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Cliente, Produto, Valor, DataEntrega);
        }
    }
}