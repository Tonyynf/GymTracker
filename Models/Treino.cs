public class Treino{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly Data { get; set; }
    public string Observacoes { get; set; }
    public List<Exercicio> Exercicios { get; set; }
}

public class Exercicio{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Repeticoes { get; set; }
    public int Series { get; set; }
}
