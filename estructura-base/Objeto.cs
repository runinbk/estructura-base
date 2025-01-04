using estructura_base;
using estructura_base.Interfaces;
using System.Numerics;


internal class Objeto : IGraphics
{
    private Dictionary<string, Parte> partes;
    public Punto centro { get; set; }

    public Objeto()
    {
        this.centro = new Punto();
        partes = new Dictionary<string, Parte>();
    }

    public Objeto(Punto punto)
    {
        this.centro = punto;
        partes = new Dictionary<string, Parte>();
    }

    public void AddParte(string key, Parte value)
    {
        this.partes.Add(key, value);
        this.centro = calcularCentroMasa();
    }

    // Métodos de la interfaz IGraphics
    public void dibujar()
    {
        foreach (var valor in partes)
        {
            valor.Value.dibujar();
        }
    }

    public void setCentro(Punto newCentro)
    {
        foreach (var valor in partes)
        {
            valor.Value.setCentro(newCentro);
        }
        this.centro = newCentro;
    }

    public void rotar(Punto angulo)
    {
        foreach (var valor in partes)
        {
            valor.Value.rotar(angulo);
        }
        this.centro = calcularCentroMasa();
    }

    public void escalar(float factor)
    {
        foreach (var valor in partes)
        {
            valor.Value.setCentro(this.centro);
            valor.Value.escalar(factor);
        }
        this.centro = calcularCentroMasa();
    }

    public void trasladar(Punto valorTrasladar)
    {
        foreach (var valor in partes)
        {
            valor.Value.setCentro(this.centro);
            valor.Value.trasladar(valorTrasladar);
        }
        this.centro = calcularCentroMasa();
    }

    public Punto calcularCentroMasa()
    {
        if (partes.Count == 0)
        {
            return new Punto(0.0f, 0.0f, 0.0f);
        }

        float ejeX = 0;
        float ejeY = 0;
        float ejeZ = 0;

        foreach (var valor in partes)
        {
            Parte parte = valor.Value;
            ejeX += parte.calcularCentroMasa().X; // Corregido de Y a X
            ejeY += parte.calcularCentroMasa().Y;
            ejeZ += parte.calcularCentroMasa().Z;
        }

        int numPartes = partes.Count;
        return new Punto(ejeX / numPartes, ejeY / numPartes, ejeZ / numPartes);
    }

    // Métodos adicionales necesarios para el AdministradorObjetos
    public Dictionary<string, Parte> GetPartes()
    {
        return partes;
    }

    public void setListaPartes(Dictionary<string, Parte> newPartes)
    {
        this.partes = newPartes;
        this.centro = calcularCentroMasa();
    }

    // Método adicional para soportar la rotación con Vector3
    public void Rotar(Vector3 axis, float angle)
    {
        // Convertir la rotación de Vector3 a Punto
        Punto anguloRotacion = new Punto(
            axis.X * angle,
            axis.Y * angle,
            axis.Z * angle
        );
        rotar(anguloRotacion);
    }

    public Punto GetCentroDeMasa()
    {
        return this.centro;
    }

    public void SetCentroDeMasa(Punto punto)
    {
        this.centro = punto;
        setCentro(punto); // Actualiza el centro en todas las partes
    }
}

