using Portafolio.Models;

namespace Portafolio.Servicios{
    public interface IRepositorioProyectos{
        List<Proyecto> obtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos{
        public List<Proyecto> obtenerProyectos(){
            return new List<Proyecto>(){
                new Proyecto{
                    titulo="Amazon",
                    descripcion="E-Commerce realizando ASP.NET Core",
                    link="https://amazon.com",
                    imagenUrl="/imagenes/amazon.png"
                },
                new Proyecto{
                    titulo="New York Times",
                    descripcion="Paginas de noticias en React",
                    link="https://nytimes.com",
                    imagenUrl="/imagenes/nyt.png"
                },
                new Proyecto{
                    titulo="Reddit",
                    descripcion="Red social para compartir en comunidades",
                    link="https://reddit.com",
                    imagenUrl="/imagenes/reddit.png"
                },
                new Proyecto{
                    titulo="Steam",
                    descripcion="Tienda en linea para comprar videojuegos",
                    link="https://store.steampowered.com",
                    imagenUrl="/imagenes/steam.png"
                }
            };
        }
    }
}
