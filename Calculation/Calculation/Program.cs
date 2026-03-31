// クラス定義
class Calculation
{
    // Mainメソッド
    static void Main()
    {
        /*
           数値を扱う
        */
        // 数値を出力
        System.Console.WriteLine(12345);

        // 足し算してみる
        System.Console.WriteLine(1 + 1 + 1); // 3 が出力
        // 引き算してみる
        System.Console.WriteLine(10 - 2); // 8 が出力
        // 掛け算してみる
        System.Console.WriteLine(2 * 3); // 6 が出力
        // 割り算してみる
        System.Console.WriteLine(10 / 2); // 5 が出力

        // 計算の優先順位は算数と同じ（掛け算が先）
        System.Console.WriteLine(2 + 2 * 10); // 22 が出力

        // 算数のように()で先に計算できる
        System.Console.WriteLine((2 + 2) * 10); // 40 が出力

        // 2で割ったあまりを表示してみる
        System.Console.WriteLine(9 % 2); // 1 が出力

    }
}