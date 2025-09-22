using System;

public class Cliente
{
    public Cliente(string? nome, string? email)
    {
        this.nome = nome;
        this.email = email;
    }

    public string nome { get; set; }
	public string email { get; set; }

}
