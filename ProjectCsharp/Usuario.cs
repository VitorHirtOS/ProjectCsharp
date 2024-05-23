using System.Collections;

namespace ProjectCsharp;

public class Usuario
{

    private String nome;
    private int idade;
    private double salario;

    public ArrayList lista()
    {

        ArrayList arrayList = new ArrayList();
      
        arrayList.Add(this.nome);
        arrayList.Add(this.idade);
        arrayList.Add(this.salario);
        
        return arrayList;
    }
    
    public Usuario(String nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
    }
    
}