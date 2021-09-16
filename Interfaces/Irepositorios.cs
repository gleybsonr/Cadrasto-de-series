using System.Collections.Generic;
namespace Dio.series.Interfaces
{
    public interface Irepositorios<T>
    {

        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void atualiza(int id, T entidade);
        int ProximoId();
    }
}