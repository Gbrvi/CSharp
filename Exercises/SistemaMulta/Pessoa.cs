using System;
using System.Runtime.CompilerServices;

abstract class Pessoa
{
    protected string? nome {set; get;}
    protected string? cpf {set; get;}

    protected int ID;

    public Pessoa(string nome, string cpf, int ID)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.ID = ID;    
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetCPF()
    {
        return cpf;
    }
}
