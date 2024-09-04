using System;

namespace API.models;

public class Produto
{
    // C# construtor da classe
    public Produto()
    {
        CriadoEm = DateTime.Now;
        Id= Guid.NewGuid().ToString();
    }
    // C# atributo get e set
    public string? Id{get; set;} 
    public string? Nome{get; set;}
    public double Preco {get; set;}
    public int Quantidade{get; set;}
    public DateTime CriadoEm { get; set; }

    //Java atributo get e set
    // private double preco;
    // public double GetPreco()
    // {
    //     return preco;
    // }
    // public void SetPreco(double preco)
    // {
    //     this.preco = preco * 3;
    // }
}
