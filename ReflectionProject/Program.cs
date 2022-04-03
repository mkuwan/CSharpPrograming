// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Reflection;
using ReflectionProject.MethodBase;

//var stopwatch = new Stopwatch();

//var asm = Assembly.GetAssembly(typeof(HttpClient));
//Console.WriteLine(asm);


// GetEntryAssemblyはプログラムのMainメソッドを含むEXEファイルを表すオブジェクトを返します
//stopwatch.Start();
//Console.WriteLine(Assembly.GetEntryAssembly());
//stopwatch.Stop();
//Console.WriteLine(stopwatch.Elapsed.Ticks);

// GetCallingAssemblyはスタックを1レベル戻り、GetCallingAssemblyを呼び出したメソッドをさらに呼び出したコードを含むアセンブリを返します
//Console.WriteLine(Assembly.GetCallingAssembly());

// Assembly.GetEntryAssembly()に比べてTypeオブジェクトを使って外側のクラスからAssemblyを取得するほうが短時間で済みます
// どちらもリフレクションオブジェクトを取得するものの、一方はスタックをたどるのでAssemblyプロパティを使うほうが少ない処理で済みます
//Console.WriteLine(@"typeof(Program)");
//stopwatch.Reset();
//stopwatch.Start();
//Console.WriteLine(Assembly.GetAssembly(typeof(Program)));
//stopwatch.Stop();
//Console.WriteLine(stopwatch.Elapsed.Ticks);

//stopwatch.Reset();
//stopwatch.Start();
//Console.WriteLine(typeof(Program).Assembly);
//stopwatch.Stop();
//Console.WriteLine(stopwatch.Elapsed.Ticks);



//var type = Type.DefaultBinder;
//Console.WriteLine(type.ToString());

//var method = MethodBase.GetCurrentMethod();
//Console.WriteLine(method?.Name);

//var member = typeof(MemberInfo);
//Console.WriteLine(member);


// TypeからMethodBaseにアクセスしてConstructorInfo, MethodInfoを取得しています
Console.WriteLine("ConstructorInfoSample");
Console.WriteLine("No Argument Constructor");
// クラスの型を取得
var classType = typeof(ConstructorInfoSample);

// 引数なし
// クラスのコンストラクタ取得(MethodBase)　
var c1 = classType.GetConstructor(Type.EmptyTypes);
// コンストラクタを実行して、クラスのインスタンスを取得します (ConstructorInfo.Invoke)
var instance1 = c1.Invoke(null);
// メソッドを取得(MethodBase)
var method1 = classType.GetMethod(nameof(ConstructorInfoSample.NoArgumentMethod));
// メソッドを実行 ( MethodBase.Invoke (MethodInfo.Invoke))
method1.Invoke(instance1, null);


// 引数あり
Console.WriteLine("With Argument Constructor");
var c2 = classType.GetConstructor(new Type[] {typeof(string)});
var instance2 = c2.Invoke(new object?[] {"引数ありテスト"});
var method2 = classType.GetMethod(nameof(ConstructorInfoSample.ArgumentMethod));
method2.Invoke(instance2, new object?[]{"引数メソッド"});


// Activatorを使用した場合
Console.WriteLine("Use Activator");
var instance3 = Activator.CreateInstance(classType);
classType.InvokeMember(nameof(ConstructorInfoSample.NoArgumentMethod),
    BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod,
    null,
    instance3,
    null);

Console.ReadLine();