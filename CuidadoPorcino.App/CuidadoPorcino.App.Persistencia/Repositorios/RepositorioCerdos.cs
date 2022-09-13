using System.Collections.Generic;

using CuidadoPorcino.App.Dominio;

using System.Linq;



namespace CuidadoPorcino.App.Persistencia{





    public class RepositorioCerdos : INRepositorioCerdos

    {



        private readonly appContext _appContext;

        public RepositorioCerdos(appContext appCon)

        {

            _appContext = appCon;

        }

        Cerdos INRepositorioCerdos.addCerdo(Cerdos Cerdo)

        {

            var CerdoAdicionado = _appContext.Cerdos.Add(Cerdo);

            _appContext.SaveChanges();

            return CerdoAdicionado.Entity;

        }

        void INRepositorioCerdos.deleteCerdo(int idCerdos)

        {

            var CerdosEncontrado = _appContext.Cerdos.FirstOrDefault(p => p.id == idCerdos);

            if (CerdosEncontrado == null)

            { return; }

            _appContext.Cerdos.Remove(CerdosEncontrado);

        }

        IEnumerable<Cerdos> INRepositorioCerdos.GetAllCerdos()

        {

            return _appContext.Cerdos;

        }

        Cerdos INRepositorioCerdos.getCerdo(int idCerdo)

        {

            return _appContext.Cerdos.FirstOrDefault(p => p.id == idCerdo);

        }

        Cerdos INRepositorioCerdos.updateCerdo(Cerdos Cerdo)

        {

            var CerdoEncontrado = _appContext.Cerdos.FirstOrDefault(p => p.id == Cerdo.id);

            if (CerdoEncontrado != null)

            {

                CerdoEncontrado.Nombre = Cerdo.Nombre;

                CerdoEncontrado.Color = Cerdo.Color;

                CerdoEncontrado.Especie = Cerdo.Especie;

                CerdoEncontrado.Raza = Cerdo.Raza;



                _appContext.SaveChanges();

            }

            return CerdoEncontrado;



        }

    }

}
