﻿using System;

namespace Blazor_tarefas.Models
{
    public class Tarefas
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
