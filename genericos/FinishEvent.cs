namespace genericos;

public class FinishEvent
{
    public Action FinishAction;

    public FinishEvent()
    {
        FinishAction = () => { };
    }
}