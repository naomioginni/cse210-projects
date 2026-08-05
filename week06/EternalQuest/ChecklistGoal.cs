public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private int _pointsEarnedLastEvent;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            _pointsEarnedLastEvent = base.GetPoints();

            if (_amountCompleted == _target)
            {
                _pointsEarnedLastEvent += _bonus;
            }
        }
        else
        {
            _pointsEarnedLastEvent = 0;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int GetPoints()
    {
        return _pointsEarnedLastEvent;
    }

    public override string GetDetailsString()
    {
        string mark = IsComplete() ? "X" : " ";
        return $"[{mark}] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{base.GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}