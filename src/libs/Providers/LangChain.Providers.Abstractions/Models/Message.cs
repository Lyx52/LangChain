namespace LangChain.Providers;

/// <summary>
/// 
/// </summary>
/// <param name="Content"></param>
/// <param name="Role"></param>
/// <param name="FunctionName"></param>
public readonly record struct Message(
    string Content,
    MessageRole Role,
    string? FunctionName = null)
{
    /// <summary>
    /// 
    /// </summary>
    public static Message Empty { get; } = new(
        Content: string.Empty,
        Role: MessageRole.Human,
        FunctionName: null);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Message operator +(Message a, Message b)
    {
        return a with { Content = a.Content + b.Content };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static Message Add(Message left, Message right)
    {
        return left + right;
    }
}