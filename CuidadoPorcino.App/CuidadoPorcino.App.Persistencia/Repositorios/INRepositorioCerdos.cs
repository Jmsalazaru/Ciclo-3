using System.Collections.Generic;

using CuidadoPorcino.App.Dominio;



namespace CuidadoPorcino.App.Persistencia{

    public interface INRepositorioCerdos{

        Cerdos addCerdo(Cerdos Cerdo);

        void deleteCerdo(int idCerdo);

        IEnumerable<Cerdos> GetAllCerdos();

        Cerdos getCerdo(int idCerdo);

        Cerdos updateCerdo(Cerdos Cerdo);

    }

}
