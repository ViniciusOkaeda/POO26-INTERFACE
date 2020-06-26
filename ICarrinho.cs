namespace AULA26INTERFACES
{
    public interface ICarrinho
    {
         void Cadastrar(Produto produto);

         void Listar();

         void Alterar(int _codigo, Produto produto);

         void Deletar(Produto produto);

         void MostrarTotal();
    }
}