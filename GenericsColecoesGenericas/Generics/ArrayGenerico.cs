
namespace Generics;

public class ArrayGenerico<T>
{
    private T[] arrayGenerico = new T[5];
    private int contador = 0;

    public void Adicionar(T objeto)
    {
        if (contador > 4) return;
        arrayGenerico[contador] = objeto;
        contador++;
    }

    public T this[int posicao]
    {
        get
        {
            if (posicao >= 0 && posicao < arrayGenerico.Length)
            {
                return arrayGenerico[posicao];
            }
            throw new IndexOutOfRangeException("Posição inválida.");
        }
        set
        {
            if (posicao >= 0 && posicao < arrayGenerico.Length)
            {
                arrayGenerico[posicao] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Posição inválida.");
            }
        }
    }

}