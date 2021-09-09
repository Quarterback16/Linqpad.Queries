<Query Kind="Program" />

void Main()
{

}

private static Nullable<T> MultipliedByTwoFunction<T>(
	Nullable<T> iNullable,
	Func<T, T> funcDelegate)
	where T : struct
{
	if (iNullable.HasValue)
	{
		T unWrappedInt = iNullable.Value;
		T multipliedByTwo = funcDelegate(unWrappedInt);
		return new Nullable<T>(
			multipliedByTwo);
	}
	else
	{
		return new Nullable<T>();
	}
}
private static Nullable<R> MultipliedByTwoFunction<V, R>(
	Nullable<V> iNullable,
	Func<V, R> funcDelegate)
		where V : struct
		where R : struct
{
	if (iNullable.HasValue)
	{
		V unWrappedInt = iNullable.Value;
		R multipliedByTwo = funcDelegate(unWrappedInt);
		return new Nullable<R>(multipliedByTwo);
	}
	else
	{
		return new Nullable<T>();
	}
}

static Lazy<R> MultipliedByTwoFunction<V, R>(
	Lazy<V> lazy,
	Func<V, R> function)
		where V : struct
		where R : struct
{
	return new Lazy<R>(() =>
	{
		V unWrappedInt = lazy.Value;
		R multipliedByTwo = function(unWrappedInt);
		return multipliedByTwo;
	});
}

private static M<R> MonadFunction<V, R>(
	M<V> amplified,
	Func<V, R> function)
{
	// Implementation
}
