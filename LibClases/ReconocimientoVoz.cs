using System;
using System.Speech.Recognition;

public class ReproductorVoz
{
    private SpeechRecognitionEngine reconocimiento;

    // Evento que notifica al exterior cuando se reconoce un comando
    public event Action<string> ComandoReconocido;

    public void IniciarReconocimiento()
    {
        // Configura el reconocimiento para español
        var cultura = new System.Globalization.CultureInfo("es-ES");
        reconocimiento = new SpeechRecognitionEngine(cultura);

        // Grupo: Reproducir
        Choices reproducirChoices = new Choices();
        reproducirChoices.Add(new SemanticResultValue("reproducir", "play"));
        reproducirChoices.Add(new SemanticResultValue("play", "play"));
        reproducirChoices.Add(new SemanticResultValue("iniciar", "play"));
        reproducirChoices.Add(new SemanticResultValue("comenzar", "play"));

        // Grupo: Pausar
        Choices pausarChoices = new Choices();
        pausarChoices.Add(new SemanticResultValue("pausar", "pause"));
        pausarChoices.Add(new SemanticResultValue("detener temporalmente", "pause"));
        pausarChoices.Add(new SemanticResultValue("pausa", "pause"));

        // Grupo: Detener
        Choices detenerChoices = new Choices();
        detenerChoices.Add(new SemanticResultValue("detener", "stop"));
        detenerChoices.Add(new SemanticResultValue("parar", "stop"));
        detenerChoices.Add(new SemanticResultValue("terminar", "stop"));

        // Grupo: Siguiente
        Choices siguienteChoices = new Choices();
        siguienteChoices.Add(new SemanticResultValue("siguiente", "next"));
        siguienteChoices.Add(new SemanticResultValue("adelantar", "next"));
        siguienteChoices.Add(new SemanticResultValue("pasar canción", "next"));

        // Grupo: Anterior
        Choices anteriorChoices = new Choices();
        anteriorChoices.Add(new SemanticResultValue("anterior", "previous"));
        anteriorChoices.Add(new SemanticResultValue("retroceder", "previous"));
        anteriorChoices.Add(new SemanticResultValue("canción anterior", "previous"));

        // Juntar todos los grupos bajo una clave común
        GrammarBuilder gb = new GrammarBuilder();
        gb.Append(new SemanticResultKey("accion", new Choices(
            reproducirChoices,
            pausarChoices,
            detenerChoices,
            siguienteChoices,
            anteriorChoices
        )));

        Grammar gramatica = new Grammar(gb);
        gramatica.Name = "ComandosMusica";
        reconocimiento.LoadGrammar(gramatica);

        reconocimiento.SetInputToDefaultAudioDevice();
        reconocimiento.SpeechRecognized += Reconocimiento_SpeechRecognized;
        reconocimiento.RecognizeAsync(RecognizeMode.Multiple);
    }

    private void Reconocimiento_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        // Extraer el valor semántico del comando
        string accion = e.Result.Semantics["accion"].Value.ToString();

        
        ComandoReconocido?.Invoke(accion);
    }
}
