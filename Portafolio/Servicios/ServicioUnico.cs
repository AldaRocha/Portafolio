namespace Portafolio.Servicios{
    public class ServicioUnico{
        public ServicioUnico(){
            obtenerGuiud = Guid.NewGuid();
        }
        public Guid obtenerGuiud{ get; private set; }
    }

    public class ServicioDelimitado{
        public ServicioDelimitado(){
            obtenerGuiud = Guid.NewGuid();
        }
        public Guid obtenerGuiud { get; private set; }
    }

    public class ServicioTransitorio{
        public ServicioTransitorio(){
            obtenerGuiud = Guid.NewGuid();
        }
        public Guid obtenerGuiud { get; private set; }
    }
}
