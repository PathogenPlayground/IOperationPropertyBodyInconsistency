class OperationPropertyBodyInconsistency
{
    int X
    {
        get
        {
            return 1;
        }
    }

    int Y
    {
        get
            => 2;
    }

    int Z
        => 3;
}
