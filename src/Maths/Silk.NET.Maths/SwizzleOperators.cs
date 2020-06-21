﻿// ReSharper disable InconsistentNaming

namespace Silk.NET.Maths
{
    public readonly partial struct Vector2<T>
    {
        public Vector2<T> XX => new Vector2<T>(X, X);
        public Vector2<T> XY => new Vector2<T>(X, Y);
        public Vector2<T> YX => new Vector2<T>(Y, X);
        public Vector2<T> YY => new Vector2<T>(Y, Y);
    }

    public readonly partial struct Vector3<T>
    {
        public Vector2<T> XX => new Vector2<T>(X, X);
        public Vector2<T> XY => new Vector2<T>(X, Y);
        public Vector2<T> YX => new Vector2<T>(Y, X);
        public Vector2<T> YY => new Vector2<T>(Y, Y);

        public Vector3<T> XXX => new Vector3<T>(X, X, X);
        public Vector3<T> XXY => new Vector3<T>(X, X, Y);
        public Vector3<T> XXZ => new Vector3<T>(X, X, Z);
        public Vector3<T> XYX => new Vector3<T>(X, Y, X);
        public Vector3<T> XYY => new Vector3<T>(X, Y, Y);
        public Vector3<T> XYZ => new Vector3<T>(X, Y, Z);
        public Vector3<T> XZX => new Vector3<T>(X, Z, X);
        public Vector3<T> XZY => new Vector3<T>(X, Z, Y);
        public Vector3<T> XZZ => new Vector3<T>(X, Z, Z);
        public Vector3<T> YXX => new Vector3<T>(Y, X, X);
        public Vector3<T> YXY => new Vector3<T>(Y, X, Y);
        public Vector3<T> YXZ => new Vector3<T>(Y, X, Z);
        public Vector3<T> YYX => new Vector3<T>(Y, Y, X);
        public Vector3<T> YYY => new Vector3<T>(Y, Y, Y);
        public Vector3<T> YYZ => new Vector3<T>(Y, Y, Z);
        public Vector3<T> YZX => new Vector3<T>(Y, Z, X);
        public Vector3<T> YZY => new Vector3<T>(Y, Z, Y);
        public Vector3<T> YZZ => new Vector3<T>(Y, Z, Z);
        public Vector3<T> ZXX => new Vector3<T>(Z, X, X);
        public Vector3<T> ZXY => new Vector3<T>(Z, X, Y);
        public Vector3<T> ZXZ => new Vector3<T>(Z, X, Z);
        public Vector3<T> ZYX => new Vector3<T>(Z, Y, X);
        public Vector3<T> ZYY => new Vector3<T>(Z, Y, Y);
        public Vector3<T> ZYZ => new Vector3<T>(Z, Y, Z);
        public Vector3<T> ZZX => new Vector3<T>(Z, Z, X);
        public Vector3<T> ZZY => new Vector3<T>(Z, Z, Y);
        public Vector3<T> ZZZ => new Vector3<T>(Z, Z, Z);
    }

    public readonly partial struct Vector4<T>
    {
        public Vector3<T> XXX => new Vector3<T>(X, X, X);
        public Vector3<T> XXY => new Vector3<T>(X, X, Y);
        public Vector3<T> XXZ => new Vector3<T>(X, X, Z);
        public Vector3<T> XYX => new Vector3<T>(X, Y, X);
        public Vector3<T> XYY => new Vector3<T>(X, Y, Y);
        public Vector3<T> XYZ => new Vector3<T>(X, Y, Z);
        public Vector3<T> XZX => new Vector3<T>(X, Z, X);
        public Vector3<T> XZY => new Vector3<T>(X, Z, Y);
        public Vector3<T> XZZ => new Vector3<T>(X, Z, Z);
        public Vector3<T> YXX => new Vector3<T>(Y, X, X);
        public Vector3<T> YXY => new Vector3<T>(Y, X, Y);
        public Vector3<T> YXZ => new Vector3<T>(Y, X, Z);
        public Vector3<T> YYX => new Vector3<T>(Y, Y, X);
        public Vector3<T> YYY => new Vector3<T>(Y, Y, Y);
        public Vector3<T> YYZ => new Vector3<T>(Y, Y, Z);
        public Vector3<T> YZX => new Vector3<T>(Y, Z, X);
        public Vector3<T> YZY => new Vector3<T>(Y, Z, Y);
        public Vector3<T> YZZ => new Vector3<T>(Y, Z, Z);
        public Vector3<T> ZXX => new Vector3<T>(Z, X, X);
        public Vector3<T> ZXY => new Vector3<T>(Z, X, Y);
        public Vector3<T> ZXZ => new Vector3<T>(Z, X, Z);
        public Vector3<T> ZYX => new Vector3<T>(Z, Y, X);
        public Vector3<T> ZYY => new Vector3<T>(Z, Y, Y);
        public Vector3<T> ZYZ => new Vector3<T>(Z, Y, Z);
        public Vector3<T> ZZX => new Vector3<T>(Z, Z, X);
        public Vector3<T> ZZY => new Vector3<T>(Z, Z, Y);
        public Vector3<T> ZZZ => new Vector3<T>(Z, Z, Z);

        public Vector4<T> XXXX => new Vector4<T>(X, X, X, X);
        public Vector4<T> XXXY => new Vector4<T>(X, X, X, Y);
        public Vector4<T> XXXZ => new Vector4<T>(X, X, X, Z);
        public Vector4<T> XXXW => new Vector4<T>(X, X, X, W);
        public Vector4<T> XXYX => new Vector4<T>(X, X, Y, X);
        public Vector4<T> XXYY => new Vector4<T>(X, X, Y, Y);
        public Vector4<T> XXYZ => new Vector4<T>(X, X, Y, Z);
        public Vector4<T> XXYW => new Vector4<T>(X, X, Y, W);
        public Vector4<T> XXZX => new Vector4<T>(X, X, Z, X);
        public Vector4<T> XXZY => new Vector4<T>(X, X, Z, Y);
        public Vector4<T> XXZZ => new Vector4<T>(X, X, Z, Z);
        public Vector4<T> XXZW => new Vector4<T>(X, X, Z, W);
        public Vector4<T> XXWX => new Vector4<T>(X, X, W, X);
        public Vector4<T> XXWY => new Vector4<T>(X, X, W, Y);
        public Vector4<T> XXWZ => new Vector4<T>(X, X, W, Z);
        public Vector4<T> XXWW => new Vector4<T>(X, X, W, W);
        public Vector4<T> XYXX => new Vector4<T>(X, Y, X, X);
        public Vector4<T> XYXY => new Vector4<T>(X, Y, X, Y);
        public Vector4<T> XYXZ => new Vector4<T>(X, Y, X, Z);
        public Vector4<T> XYXW => new Vector4<T>(X, Y, X, W);
        public Vector4<T> XYYX => new Vector4<T>(X, Y, Y, X);
        public Vector4<T> XYYY => new Vector4<T>(X, Y, Y, Y);
        public Vector4<T> XYYZ => new Vector4<T>(X, Y, Y, Z);
        public Vector4<T> XYYW => new Vector4<T>(X, Y, Y, W);
        public Vector4<T> XYZX => new Vector4<T>(X, Y, Z, X);
        public Vector4<T> XYZY => new Vector4<T>(X, Y, Z, Y);
        public Vector4<T> XYZZ => new Vector4<T>(X, Y, Z, Z);
        public Vector4<T> XYZW => new Vector4<T>(X, Y, Z, W);
        public Vector4<T> XYWX => new Vector4<T>(X, Y, W, X);
        public Vector4<T> XYWY => new Vector4<T>(X, Y, W, Y);
        public Vector4<T> XYWZ => new Vector4<T>(X, Y, W, Z);
        public Vector4<T> XYWW => new Vector4<T>(X, Y, W, W);
        public Vector4<T> XZXX => new Vector4<T>(X, Z, X, X);
        public Vector4<T> XZXY => new Vector4<T>(X, Z, X, Y);
        public Vector4<T> XZXZ => new Vector4<T>(X, Z, X, Z);
        public Vector4<T> XZXW => new Vector4<T>(X, Z, X, W);
        public Vector4<T> XZYX => new Vector4<T>(X, Z, Y, X);
        public Vector4<T> XZYY => new Vector4<T>(X, Z, Y, Y);
        public Vector4<T> XZYZ => new Vector4<T>(X, Z, Y, Z);
        public Vector4<T> XZYW => new Vector4<T>(X, Z, Y, W);
        public Vector4<T> XZZX => new Vector4<T>(X, Z, Z, X);
        public Vector4<T> XZZY => new Vector4<T>(X, Z, Z, Y);
        public Vector4<T> XZZZ => new Vector4<T>(X, Z, Z, Z);
        public Vector4<T> XZZW => new Vector4<T>(X, Z, Z, W);
        public Vector4<T> XZWX => new Vector4<T>(X, Z, W, X);
        public Vector4<T> XZWY => new Vector4<T>(X, Z, W, Y);
        public Vector4<T> XZWZ => new Vector4<T>(X, Z, W, Z);
        public Vector4<T> XZWW => new Vector4<T>(X, Z, W, W);
        public Vector4<T> XWXX => new Vector4<T>(X, W, X, X);
        public Vector4<T> XWXY => new Vector4<T>(X, W, X, Y);
        public Vector4<T> XWXZ => new Vector4<T>(X, W, X, Z);
        public Vector4<T> XWXW => new Vector4<T>(X, W, X, W);
        public Vector4<T> XWYX => new Vector4<T>(X, W, Y, X);
        public Vector4<T> XWYY => new Vector4<T>(X, W, Y, Y);
        public Vector4<T> XWYZ => new Vector4<T>(X, W, Y, Z);
        public Vector4<T> XWYW => new Vector4<T>(X, W, Y, W);
        public Vector4<T> XWZX => new Vector4<T>(X, W, Z, X);
        public Vector4<T> XWZY => new Vector4<T>(X, W, Z, Y);
        public Vector4<T> XWZZ => new Vector4<T>(X, W, Z, Z);
        public Vector4<T> XWZW => new Vector4<T>(X, W, Z, W);
        public Vector4<T> XWWX => new Vector4<T>(X, W, W, X);
        public Vector4<T> XWWY => new Vector4<T>(X, W, W, Y);
        public Vector4<T> XWWZ => new Vector4<T>(X, W, W, Z);
        public Vector4<T> XWWW => new Vector4<T>(X, W, W, W);
        public Vector4<T> YXXX => new Vector4<T>(Y, X, X, X);
        public Vector4<T> YXXY => new Vector4<T>(Y, X, X, Y);
        public Vector4<T> YXXZ => new Vector4<T>(Y, X, X, Z);
        public Vector4<T> YXXW => new Vector4<T>(Y, X, X, W);
        public Vector4<T> YXYX => new Vector4<T>(Y, X, Y, X);
        public Vector4<T> YXYY => new Vector4<T>(Y, X, Y, Y);
        public Vector4<T> YXYZ => new Vector4<T>(Y, X, Y, Z);
        public Vector4<T> YXYW => new Vector4<T>(Y, X, Y, W);
        public Vector4<T> YXZX => new Vector4<T>(Y, X, Z, X);
        public Vector4<T> YXZY => new Vector4<T>(Y, X, Z, Y);
        public Vector4<T> YXZZ => new Vector4<T>(Y, X, Z, Z);
        public Vector4<T> YXZW => new Vector4<T>(Y, X, Z, W);
        public Vector4<T> YXWX => new Vector4<T>(Y, X, W, X);
        public Vector4<T> YXWY => new Vector4<T>(Y, X, W, Y);
        public Vector4<T> YXWZ => new Vector4<T>(Y, X, W, Z);
        public Vector4<T> YXWW => new Vector4<T>(Y, X, W, W);
        public Vector4<T> YYXX => new Vector4<T>(Y, Y, X, X);
        public Vector4<T> YYXY => new Vector4<T>(Y, Y, X, Y);
        public Vector4<T> YYXZ => new Vector4<T>(Y, Y, X, Z);
        public Vector4<T> YYXW => new Vector4<T>(Y, Y, X, W);
        public Vector4<T> YYYX => new Vector4<T>(Y, Y, Y, X);
        public Vector4<T> YYYY => new Vector4<T>(Y, Y, Y, Y);
        public Vector4<T> YYYZ => new Vector4<T>(Y, Y, Y, Z);
        public Vector4<T> YYYW => new Vector4<T>(Y, Y, Y, W);
        public Vector4<T> YYZX => new Vector4<T>(Y, Y, Z, X);
        public Vector4<T> YYZY => new Vector4<T>(Y, Y, Z, Y);
        public Vector4<T> YYZZ => new Vector4<T>(Y, Y, Z, Z);
        public Vector4<T> YYZW => new Vector4<T>(Y, Y, Z, W);
        public Vector4<T> YYWX => new Vector4<T>(Y, Y, W, X);
        public Vector4<T> YYWY => new Vector4<T>(Y, Y, W, Y);
        public Vector4<T> YYWZ => new Vector4<T>(Y, Y, W, Z);
        public Vector4<T> YYWW => new Vector4<T>(Y, Y, W, W);
        public Vector4<T> YZXX => new Vector4<T>(Y, Z, X, X);
        public Vector4<T> YZXY => new Vector4<T>(Y, Z, X, Y);
        public Vector4<T> YZXZ => new Vector4<T>(Y, Z, X, Z);
        public Vector4<T> YZXW => new Vector4<T>(Y, Z, X, W);
        public Vector4<T> YZYX => new Vector4<T>(Y, Z, Y, X);
        public Vector4<T> YZYY => new Vector4<T>(Y, Z, Y, Y);
        public Vector4<T> YZYZ => new Vector4<T>(Y, Z, Y, Z);
        public Vector4<T> YZYW => new Vector4<T>(Y, Z, Y, W);
        public Vector4<T> YZZX => new Vector4<T>(Y, Z, Z, X);
        public Vector4<T> YZZY => new Vector4<T>(Y, Z, Z, Y);
        public Vector4<T> YZZZ => new Vector4<T>(Y, Z, Z, Z);
        public Vector4<T> YZZW => new Vector4<T>(Y, Z, Z, W);
        public Vector4<T> YZWX => new Vector4<T>(Y, Z, W, X);
        public Vector4<T> YZWY => new Vector4<T>(Y, Z, W, Y);
        public Vector4<T> YZWZ => new Vector4<T>(Y, Z, W, Z);
        public Vector4<T> YZWW => new Vector4<T>(Y, Z, W, W);
        public Vector4<T> YWXX => new Vector4<T>(Y, W, X, X);
        public Vector4<T> YWXY => new Vector4<T>(Y, W, X, Y);
        public Vector4<T> YWXZ => new Vector4<T>(Y, W, X, Z);
        public Vector4<T> YWXW => new Vector4<T>(Y, W, X, W);
        public Vector4<T> YWYX => new Vector4<T>(Y, W, Y, X);
        public Vector4<T> YWYY => new Vector4<T>(Y, W, Y, Y);
        public Vector4<T> YWYZ => new Vector4<T>(Y, W, Y, Z);
        public Vector4<T> YWYW => new Vector4<T>(Y, W, Y, W);
        public Vector4<T> YWZX => new Vector4<T>(Y, W, Z, X);
        public Vector4<T> YWZY => new Vector4<T>(Y, W, Z, Y);
        public Vector4<T> YWZZ => new Vector4<T>(Y, W, Z, Z);
        public Vector4<T> YWZW => new Vector4<T>(Y, W, Z, W);
        public Vector4<T> YWWX => new Vector4<T>(Y, W, W, X);
        public Vector4<T> YWWY => new Vector4<T>(Y, W, W, Y);
        public Vector4<T> YWWZ => new Vector4<T>(Y, W, W, Z);
        public Vector4<T> YWWW => new Vector4<T>(Y, W, W, W);
        public Vector4<T> ZXXX => new Vector4<T>(Z, X, X, X);
        public Vector4<T> ZXXY => new Vector4<T>(Z, X, X, Y);
        public Vector4<T> ZXXZ => new Vector4<T>(Z, X, X, Z);
        public Vector4<T> ZXXW => new Vector4<T>(Z, X, X, W);
        public Vector4<T> ZXYX => new Vector4<T>(Z, X, Y, X);
        public Vector4<T> ZXYY => new Vector4<T>(Z, X, Y, Y);
        public Vector4<T> ZXYZ => new Vector4<T>(Z, X, Y, Z);
        public Vector4<T> ZXYW => new Vector4<T>(Z, X, Y, W);
        public Vector4<T> ZXZX => new Vector4<T>(Z, X, Z, X);
        public Vector4<T> ZXZY => new Vector4<T>(Z, X, Z, Y);
        public Vector4<T> ZXZZ => new Vector4<T>(Z, X, Z, Z);
        public Vector4<T> ZXZW => new Vector4<T>(Z, X, Z, W);
        public Vector4<T> ZXWX => new Vector4<T>(Z, X, W, X);
        public Vector4<T> ZXWY => new Vector4<T>(Z, X, W, Y);
        public Vector4<T> ZXWZ => new Vector4<T>(Z, X, W, Z);
        public Vector4<T> ZXWW => new Vector4<T>(Z, X, W, W);
        public Vector4<T> ZYXX => new Vector4<T>(Z, Y, X, X);
        public Vector4<T> ZYXY => new Vector4<T>(Z, Y, X, Y);
        public Vector4<T> ZYXZ => new Vector4<T>(Z, Y, X, Z);
        public Vector4<T> ZYXW => new Vector4<T>(Z, Y, X, W);
        public Vector4<T> ZYYX => new Vector4<T>(Z, Y, Y, X);
        public Vector4<T> ZYYY => new Vector4<T>(Z, Y, Y, Y);
        public Vector4<T> ZYYZ => new Vector4<T>(Z, Y, Y, Z);
        public Vector4<T> ZYYW => new Vector4<T>(Z, Y, Y, W);
        public Vector4<T> ZYZX => new Vector4<T>(Z, Y, Z, X);
        public Vector4<T> ZYZY => new Vector4<T>(Z, Y, Z, Y);
        public Vector4<T> ZYZZ => new Vector4<T>(Z, Y, Z, Z);
        public Vector4<T> ZYZW => new Vector4<T>(Z, Y, Z, W);
        public Vector4<T> ZYWX => new Vector4<T>(Z, Y, W, X);
        public Vector4<T> ZYWY => new Vector4<T>(Z, Y, W, Y);
        public Vector4<T> ZYWZ => new Vector4<T>(Z, Y, W, Z);
        public Vector4<T> ZYWW => new Vector4<T>(Z, Y, W, W);
        public Vector4<T> ZZXX => new Vector4<T>(Z, Z, X, X);
        public Vector4<T> ZZXY => new Vector4<T>(Z, Z, X, Y);
        public Vector4<T> ZZXZ => new Vector4<T>(Z, Z, X, Z);
        public Vector4<T> ZZXW => new Vector4<T>(Z, Z, X, W);
        public Vector4<T> ZZYX => new Vector4<T>(Z, Z, Y, X);
        public Vector4<T> ZZYY => new Vector4<T>(Z, Z, Y, Y);
        public Vector4<T> ZZYZ => new Vector4<T>(Z, Z, Y, Z);
        public Vector4<T> ZZYW => new Vector4<T>(Z, Z, Y, W);
        public Vector4<T> ZZZX => new Vector4<T>(Z, Z, Z, X);
        public Vector4<T> ZZZY => new Vector4<T>(Z, Z, Z, Y);
        public Vector4<T> ZZZZ => new Vector4<T>(Z, Z, Z, Z);
        public Vector4<T> ZZZW => new Vector4<T>(Z, Z, Z, W);
        public Vector4<T> ZZWX => new Vector4<T>(Z, Z, W, X);
        public Vector4<T> ZZWY => new Vector4<T>(Z, Z, W, Y);
        public Vector4<T> ZZWZ => new Vector4<T>(Z, Z, W, Z);
        public Vector4<T> ZZWW => new Vector4<T>(Z, Z, W, W);
        public Vector4<T> ZWXX => new Vector4<T>(Z, W, X, X);
        public Vector4<T> ZWXY => new Vector4<T>(Z, W, X, Y);
        public Vector4<T> ZWXZ => new Vector4<T>(Z, W, X, Z);
        public Vector4<T> ZWXW => new Vector4<T>(Z, W, X, W);
        public Vector4<T> ZWYX => new Vector4<T>(Z, W, Y, X);
        public Vector4<T> ZWYY => new Vector4<T>(Z, W, Y, Y);
        public Vector4<T> ZWYZ => new Vector4<T>(Z, W, Y, Z);
        public Vector4<T> ZWYW => new Vector4<T>(Z, W, Y, W);
        public Vector4<T> ZWZX => new Vector4<T>(Z, W, Z, X);
        public Vector4<T> ZWZY => new Vector4<T>(Z, W, Z, Y);
        public Vector4<T> ZWZZ => new Vector4<T>(Z, W, Z, Z);
        public Vector4<T> ZWZW => new Vector4<T>(Z, W, Z, W);
        public Vector4<T> ZWWX => new Vector4<T>(Z, W, W, X);
        public Vector4<T> ZWWY => new Vector4<T>(Z, W, W, Y);
        public Vector4<T> ZWWZ => new Vector4<T>(Z, W, W, Z);
        public Vector4<T> ZWWW => new Vector4<T>(Z, W, W, W);
        public Vector4<T> WXXX => new Vector4<T>(W, X, X, X);
        public Vector4<T> WXXY => new Vector4<T>(W, X, X, Y);
        public Vector4<T> WXXZ => new Vector4<T>(W, X, X, Z);
        public Vector4<T> WXXW => new Vector4<T>(W, X, X, W);
        public Vector4<T> WXYX => new Vector4<T>(W, X, Y, X);
        public Vector4<T> WXYY => new Vector4<T>(W, X, Y, Y);
        public Vector4<T> WXYZ => new Vector4<T>(W, X, Y, Z);
        public Vector4<T> WXYW => new Vector4<T>(W, X, Y, W);
        public Vector4<T> WXZX => new Vector4<T>(W, X, Z, X);
        public Vector4<T> WXZY => new Vector4<T>(W, X, Z, Y);
        public Vector4<T> WXZZ => new Vector4<T>(W, X, Z, Z);
        public Vector4<T> WXZW => new Vector4<T>(W, X, Z, W);
        public Vector4<T> WXWX => new Vector4<T>(W, X, W, X);
        public Vector4<T> WXWY => new Vector4<T>(W, X, W, Y);
        public Vector4<T> WXWZ => new Vector4<T>(W, X, W, Z);
        public Vector4<T> WXWW => new Vector4<T>(W, X, W, W);
        public Vector4<T> WYXX => new Vector4<T>(W, Y, X, X);
        public Vector4<T> WYXY => new Vector4<T>(W, Y, X, Y);
        public Vector4<T> WYXZ => new Vector4<T>(W, Y, X, Z);
        public Vector4<T> WYXW => new Vector4<T>(W, Y, X, W);
        public Vector4<T> WYYX => new Vector4<T>(W, Y, Y, X);
        public Vector4<T> WYYY => new Vector4<T>(W, Y, Y, Y);
        public Vector4<T> WYYZ => new Vector4<T>(W, Y, Y, Z);
        public Vector4<T> WYYW => new Vector4<T>(W, Y, Y, W);
        public Vector4<T> WYZX => new Vector4<T>(W, Y, Z, X);
        public Vector4<T> WYZY => new Vector4<T>(W, Y, Z, Y);
        public Vector4<T> WYZZ => new Vector4<T>(W, Y, Z, Z);
        public Vector4<T> WYZW => new Vector4<T>(W, Y, Z, W);
        public Vector4<T> WYWX => new Vector4<T>(W, Y, W, X);
        public Vector4<T> WYWY => new Vector4<T>(W, Y, W, Y);
        public Vector4<T> WYWZ => new Vector4<T>(W, Y, W, Z);
        public Vector4<T> WYWW => new Vector4<T>(W, Y, W, W);
        public Vector4<T> WZXX => new Vector4<T>(W, Z, X, X);
        public Vector4<T> WZXY => new Vector4<T>(W, Z, X, Y);
        public Vector4<T> WZXZ => new Vector4<T>(W, Z, X, Z);
        public Vector4<T> WZXW => new Vector4<T>(W, Z, X, W);
        public Vector4<T> WZYX => new Vector4<T>(W, Z, Y, X);
        public Vector4<T> WZYY => new Vector4<T>(W, Z, Y, Y);
        public Vector4<T> WZYZ => new Vector4<T>(W, Z, Y, Z);
        public Vector4<T> WZYW => new Vector4<T>(W, Z, Y, W);
        public Vector4<T> WZZX => new Vector4<T>(W, Z, Z, X);
        public Vector4<T> WZZY => new Vector4<T>(W, Z, Z, Y);
        public Vector4<T> WZZZ => new Vector4<T>(W, Z, Z, Z);
        public Vector4<T> WZZW => new Vector4<T>(W, Z, Z, W);
        public Vector4<T> WZWX => new Vector4<T>(W, Z, W, X);
        public Vector4<T> WZWY => new Vector4<T>(W, Z, W, Y);
        public Vector4<T> WZWZ => new Vector4<T>(W, Z, W, Z);
        public Vector4<T> WZWW => new Vector4<T>(W, Z, W, W);
        public Vector4<T> WWXX => new Vector4<T>(W, W, X, X);
        public Vector4<T> WWXY => new Vector4<T>(W, W, X, Y);
        public Vector4<T> WWXZ => new Vector4<T>(W, W, X, Z);
        public Vector4<T> WWXW => new Vector4<T>(W, W, X, W);
        public Vector4<T> WWYX => new Vector4<T>(W, W, Y, X);
        public Vector4<T> WWYY => new Vector4<T>(W, W, Y, Y);
        public Vector4<T> WWYZ => new Vector4<T>(W, W, Y, Z);
        public Vector4<T> WWYW => new Vector4<T>(W, W, Y, W);
        public Vector4<T> WWZX => new Vector4<T>(W, W, Z, X);
        public Vector4<T> WWZY => new Vector4<T>(W, W, Z, Y);
        public Vector4<T> WWZZ => new Vector4<T>(W, W, Z, Z);
        public Vector4<T> WWZW => new Vector4<T>(W, W, Z, W);
        public Vector4<T> WWWX => new Vector4<T>(W, W, W, X);
        public Vector4<T> WWWY => new Vector4<T>(W, W, W, Y);
        public Vector4<T> WWWZ => new Vector4<T>(W, W, W, Z);
        public Vector4<T> WWWW => new Vector4<T>(W, W, W, W);
    }
}
