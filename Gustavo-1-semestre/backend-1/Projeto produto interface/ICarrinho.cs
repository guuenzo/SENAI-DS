namespace Projeto_produto_interface
{
    public interface ICarrinho
    {
        // regras do "contrato"
        //metodos que deverao aqui ser declarados apenas

        //CRUD: create, read, update, delete

        //padrao de chamada de metodo
        //tipo Nome (parametros
        
        //create
        void Adcionar(Produto _produto);

        //read
        void Listar();

        //update
        void Atualizar(int _codigo, Produto _produto);

        //delete
        void Remover(Produto _produto);
    }
}