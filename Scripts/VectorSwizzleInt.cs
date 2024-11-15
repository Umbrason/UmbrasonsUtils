using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorSwizzleInt
{
    public static Vector3Int _xxx(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.x); }
    public static Vector3Int _xxy(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.y); }
    public static Vector3Int _xx0(this Vector2Int v) { return new Vector3Int(v.x, v.x, 0); }
    public static Vector3Int _xx1(this Vector2Int v) { return new Vector3Int(v.x, v.x, 1); }
    public static Vector3Int _xyx(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.x); }
    public static Vector3Int _xyy(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.y); }
    public static Vector3Int _xy0(this Vector2Int v) { return new Vector3Int(v.x, v.y, 0); }
    public static Vector3Int _xy1(this Vector2Int v) { return new Vector3Int(v.x, v.y, 1); }
    public static Vector3Int _x0x(this Vector2Int v) { return new Vector3Int(v.x, 0, v.x); }
    public static Vector3Int _x0y(this Vector2Int v) { return new Vector3Int(v.x, 0, v.y); }
    public static Vector3Int _x00(this Vector2Int v) { return new Vector3Int(v.x, 0, 0); }
    public static Vector3Int _x01(this Vector2Int v) { return new Vector3Int(v.x, 0, 1); }
    public static Vector3Int _x1x(this Vector2Int v) { return new Vector3Int(v.x, 1, v.x); }
    public static Vector3Int _x1y(this Vector2Int v) { return new Vector3Int(v.x, 1, v.y); }
    public static Vector3Int _x10(this Vector2Int v) { return new Vector3Int(v.x, 1, 0); }
    public static Vector3Int _x11(this Vector2Int v) { return new Vector3Int(v.x, 1, 1); }
    public static Vector3Int _yxx(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.x); }
    public static Vector3Int _yxy(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.y); }
    public static Vector3Int _yx0(this Vector2Int v) { return new Vector3Int(v.y, v.x, 0); }
    public static Vector3Int _yx1(this Vector2Int v) { return new Vector3Int(v.y, v.x, 1); }
    public static Vector3Int _yyx(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.x); }
    public static Vector3Int _yyy(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.y); }
    public static Vector3Int _yy0(this Vector2Int v) { return new Vector3Int(v.y, v.y, 0); }
    public static Vector3Int _yy1(this Vector2Int v) { return new Vector3Int(v.y, v.y, 1); }
    public static Vector3Int _y0x(this Vector2Int v) { return new Vector3Int(v.y, 0, v.x); }
    public static Vector3Int _y0y(this Vector2Int v) { return new Vector3Int(v.y, 0, v.y); }
    public static Vector3Int _y00(this Vector2Int v) { return new Vector3Int(v.y, 0, 0); }
    public static Vector3Int _y01(this Vector2Int v) { return new Vector3Int(v.y, 0, 1); }
    public static Vector3Int _y1x(this Vector2Int v) { return new Vector3Int(v.y, 1, v.x); }
    public static Vector3Int _y1y(this Vector2Int v) { return new Vector3Int(v.y, 1, v.y); }
    public static Vector3Int _y10(this Vector2Int v) { return new Vector3Int(v.y, 1, 0); }
    public static Vector3Int _y11(this Vector2Int v) { return new Vector3Int(v.y, 1, 1); }
    public static Vector3Int _0xx(this Vector2Int v) { return new Vector3Int(0, v.x, v.x); }
    public static Vector3Int _0xy(this Vector2Int v) { return new Vector3Int(0, v.x, v.y); }
    public static Vector3Int _0x0(this Vector2Int v) { return new Vector3Int(0, v.x, 0); }
    public static Vector3Int _0x1(this Vector2Int v) { return new Vector3Int(0, v.x, 1); }
    public static Vector3Int _0yx(this Vector2Int v) { return new Vector3Int(0, v.y, v.x); }
    public static Vector3Int _0yy(this Vector2Int v) { return new Vector3Int(0, v.y, v.y); }
    public static Vector3Int _0y0(this Vector2Int v) { return new Vector3Int(0, v.y, 0); }
    public static Vector3Int _0y1(this Vector2Int v) { return new Vector3Int(0, v.y, 1); }
    public static Vector3Int _00x(this Vector2Int v) { return new Vector3Int(0, 0, v.x); }
    public static Vector3Int _00y(this Vector2Int v) { return new Vector3Int(0, 0, v.y); }
    public static Vector3Int _000(this Vector2Int v) { return new Vector3Int(0, 0, 0); }
    public static Vector3Int _001(this Vector2Int v) { return new Vector3Int(0, 0, 1); }
    public static Vector3Int _01x(this Vector2Int v) { return new Vector3Int(0, 1, v.x); }
    public static Vector3Int _01y(this Vector2Int v) { return new Vector3Int(0, 1, v.y); }
    public static Vector3Int _010(this Vector2Int v) { return new Vector3Int(0, 1, 0); }
    public static Vector3Int _011(this Vector2Int v) { return new Vector3Int(0, 1, 1); }
    public static Vector3Int _1xx(this Vector2Int v) { return new Vector3Int(1, v.x, v.x); }
    public static Vector3Int _1xy(this Vector2Int v) { return new Vector3Int(1, v.x, v.y); }
    public static Vector3Int _1x0(this Vector2Int v) { return new Vector3Int(1, v.x, 0); }
    public static Vector3Int _1x1(this Vector2Int v) { return new Vector3Int(1, v.x, 1); }
    public static Vector3Int _1yx(this Vector2Int v) { return new Vector3Int(1, v.y, v.x); }
    public static Vector3Int _1yy(this Vector2Int v) { return new Vector3Int(1, v.y, v.y); }
    public static Vector3Int _1y0(this Vector2Int v) { return new Vector3Int(1, v.y, 0); }
    public static Vector3Int _1y1(this Vector2Int v) { return new Vector3Int(1, v.y, 1); }
    public static Vector3Int _10x(this Vector2Int v) { return new Vector3Int(1, 0, v.x); }
    public static Vector3Int _10y(this Vector2Int v) { return new Vector3Int(1, 0, v.y); }
    public static Vector3Int _100(this Vector2Int v) { return new Vector3Int(1, 0, 0); }
    public static Vector3Int _101(this Vector2Int v) { return new Vector3Int(1, 0, 1); }
    public static Vector3Int _11x(this Vector2Int v) { return new Vector3Int(1, 1, v.x); }
    public static Vector3Int _11y(this Vector2Int v) { return new Vector3Int(1, 1, v.y); }
    public static Vector3Int _110(this Vector2Int v) { return new Vector3Int(1, 1, 0); }
    public static Vector3Int _111(this Vector2Int v) { return new Vector3Int(1, 1, 1); }

    public static Vector2Int _xx(this Vector3Int v) => new Vector2Int(v.x, v.x);
    public static Vector2Int _xy(this Vector3Int v) => new Vector2Int(v.x, v.y);
    public static Vector2Int _xz(this Vector3Int v) => new Vector2Int(v.x, v.z);
    public static Vector2Int _x0(this Vector3Int v) => new Vector2Int(v.x, 0);
    public static Vector2Int _x1(this Vector3Int v) => new Vector2Int(v.x, 1);

    public static Vector2Int _yx(this Vector3Int v) => new Vector2Int(v.y, v.x);
    public static Vector2Int _yy(this Vector3Int v) => new Vector2Int(v.y, v.y);
    public static Vector2Int _yz(this Vector3Int v) => new Vector2Int(v.y, v.z);
    public static Vector2Int _y0(this Vector3Int v) => new Vector2Int(v.y, 0);
    public static Vector2Int _y1(this Vector3Int v) => new Vector2Int(v.y, 1);

    public static Vector2Int _zx(this Vector3Int v) => new Vector2Int(v.z, v.x);
    public static Vector2Int _zy(this Vector3Int v) => new Vector2Int(v.z, v.y);
    public static Vector2Int _zz(this Vector3Int v) => new Vector2Int(v.z, v.z);
    public static Vector2Int _z0(this Vector3Int v) => new Vector2Int(v.z, 0);
    public static Vector2Int _z1(this Vector3Int v) => new Vector2Int(v.z, 1);

    public static Vector2Int _0x(this Vector3Int v) => new Vector2Int(0, v.x);
    public static Vector2Int _0y(this Vector3Int v) => new Vector2Int(0, v.y);
    public static Vector2Int _0z(this Vector3Int v) => new Vector2Int(0, v.z);
    public static Vector2Int _00(this Vector3Int v) => new Vector2Int(0, 0);
    public static Vector2Int _01(this Vector3Int v) => new Vector2Int(0, 1);

    public static Vector2Int _1x(this Vector3Int v) => new Vector2Int(1, v.x);
    public static Vector2Int _1y(this Vector3Int v) => new Vector2Int(1, v.y);
    public static Vector2Int _1z(this Vector3Int v) => new Vector2Int(1, v.z);
    public static Vector2Int _10(this Vector3Int v) => new Vector2Int(1, 0);
    public static Vector2Int _11(this Vector3Int v) => new Vector2Int(1, 1);

    public static Vector2Int _xx(this Vector2Int v) => new Vector2Int(v.x, v.x);
    public static Vector2Int _xy(this Vector2Int v) => new Vector2Int(v.x, v.y);
    public static Vector2Int _x0(this Vector2Int v) => new Vector2Int(v.x, 0);
    public static Vector2Int _x1(this Vector2Int v) => new Vector2Int(v.x, 1);

    public static Vector2Int _yx(this Vector2Int v) => new Vector2Int(v.y, v.x);
    public static Vector2Int _yy(this Vector2Int v) => new Vector2Int(v.y, v.y);    
    public static Vector2Int _y0(this Vector2Int v) => new Vector2Int(v.y, 0);
    public static Vector2Int _y1(this Vector2Int v) => new Vector2Int(v.y, 1);
    
    public static Vector2Int _0x(this Vector2Int v) => new Vector2Int(0, v.x);
    public static Vector2Int _0y(this Vector2Int v) => new Vector2Int(0, v.y);
    public static Vector2Int _00(this Vector2Int v) => new Vector2Int(0, 0);
    public static Vector2Int _01(this Vector2Int v) => new Vector2Int(0, 1);

    public static Vector2Int _1x(this Vector2Int v) => new Vector2Int(1, v.x);
    public static Vector2Int _1y(this Vector2Int v) => new Vector2Int(1, v.y);
    public static Vector2Int _10(this Vector2Int v) => new Vector2Int(1, 0);
    public static Vector2Int _11(this Vector2Int v) => new Vector2Int(1, 1);

    public static Vector3Int _xxx(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.x); }
    public static Vector3Int _xxy(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.y); }
    public static Vector3Int _xxz(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.z); }
    public static Vector3Int _xx0(this Vector3Int v) { return new Vector3Int(v.x, v.x, 0); }
    public static Vector3Int _xx1(this Vector3Int v) { return new Vector3Int(v.x, v.x, 1); }
    public static Vector3Int _xyx(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.x); }
    public static Vector3Int _xyy(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.y); }
    public static Vector3Int _xyz(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.z); }
    public static Vector3Int _xy0(this Vector3Int v) { return new Vector3Int(v.x, v.y, 0); }
    public static Vector3Int _xy1(this Vector3Int v) { return new Vector3Int(v.x, v.y, 1); }
    public static Vector3Int _xzx(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.x); }
    public static Vector3Int _xzy(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.y); }
    public static Vector3Int _xzz(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.z); }
    public static Vector3Int _xz0(this Vector3Int v) { return new Vector3Int(v.x, v.z, 0); }
    public static Vector3Int _xz1(this Vector3Int v) { return new Vector3Int(v.x, v.z, 1); }
    public static Vector3Int _x0x(this Vector3Int v) { return new Vector3Int(v.x, 0, v.x); }
    public static Vector3Int _x0y(this Vector3Int v) { return new Vector3Int(v.x, 0, v.y); }
    public static Vector3Int _x0z(this Vector3Int v) { return new Vector3Int(v.x, 0, v.z); }
    public static Vector3Int _x00(this Vector3Int v) { return new Vector3Int(v.x, 0, 0); }
    public static Vector3Int _x01(this Vector3Int v) { return new Vector3Int(v.x, 0, 1); }
    public static Vector3Int _x1x(this Vector3Int v) { return new Vector3Int(v.x, 1, v.x); }
    public static Vector3Int _x1y(this Vector3Int v) { return new Vector3Int(v.x, 1, v.y); }
    public static Vector3Int _x1z(this Vector3Int v) { return new Vector3Int(v.x, 1, v.z); }
    public static Vector3Int _x10(this Vector3Int v) { return new Vector3Int(v.x, 1, 0); }
    public static Vector3Int _x11(this Vector3Int v) { return new Vector3Int(v.x, 1, 1); }
    public static Vector3Int _yxx(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.x); }
    public static Vector3Int _yxy(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.y); }
    public static Vector3Int _yxz(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.z); }
    public static Vector3Int _yx0(this Vector3Int v) { return new Vector3Int(v.y, v.x, 0); }
    public static Vector3Int _yx1(this Vector3Int v) { return new Vector3Int(v.y, v.x, 1); }
    public static Vector3Int _yyx(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.x); }
    public static Vector3Int _yyy(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.y); }
    public static Vector3Int _yyz(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.z); }
    public static Vector3Int _yy0(this Vector3Int v) { return new Vector3Int(v.y, v.y, 0); }
    public static Vector3Int _yy1(this Vector3Int v) { return new Vector3Int(v.y, v.y, 1); }
    public static Vector3Int _yzx(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.x); }
    public static Vector3Int _yzy(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.y); }
    public static Vector3Int _yzz(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.z); }
    public static Vector3Int _yz0(this Vector3Int v) { return new Vector3Int(v.y, v.z, 0); }
    public static Vector3Int _yz1(this Vector3Int v) { return new Vector3Int(v.y, v.z, 1); }
    public static Vector3Int _y0x(this Vector3Int v) { return new Vector3Int(v.y, 0, v.x); }
    public static Vector3Int _y0y(this Vector3Int v) { return new Vector3Int(v.y, 0, v.y); }
    public static Vector3Int _y0z(this Vector3Int v) { return new Vector3Int(v.y, 0, v.z); }
    public static Vector3Int _y00(this Vector3Int v) { return new Vector3Int(v.y, 0, 0); }
    public static Vector3Int _y01(this Vector3Int v) { return new Vector3Int(v.y, 0, 1); }
    public static Vector3Int _y1x(this Vector3Int v) { return new Vector3Int(v.y, 1, v.x); }
    public static Vector3Int _y1y(this Vector3Int v) { return new Vector3Int(v.y, 1, v.y); }
    public static Vector3Int _y1z(this Vector3Int v) { return new Vector3Int(v.y, 1, v.z); }
    public static Vector3Int _y10(this Vector3Int v) { return new Vector3Int(v.y, 1, 0); }
    public static Vector3Int _y11(this Vector3Int v) { return new Vector3Int(v.y, 1, 1); }
    public static Vector3Int _zxx(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.x); }
    public static Vector3Int _zxy(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.y); }
    public static Vector3Int _zxz(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.z); }
    public static Vector3Int _zx0(this Vector3Int v) { return new Vector3Int(v.z, v.x, 0); }
    public static Vector3Int _zx1(this Vector3Int v) { return new Vector3Int(v.z, v.x, 1); }
    public static Vector3Int _zyx(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.x); }
    public static Vector3Int _zyy(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.y); }
    public static Vector3Int _zyz(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.z); }
    public static Vector3Int _zy0(this Vector3Int v) { return new Vector3Int(v.z, v.y, 0); }
    public static Vector3Int _zy1(this Vector3Int v) { return new Vector3Int(v.z, v.y, 1); }
    public static Vector3Int _zzx(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.x); }
    public static Vector3Int _zzy(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.y); }
    public static Vector3Int _zzz(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.z); }
    public static Vector3Int _zz0(this Vector3Int v) { return new Vector3Int(v.z, v.z, 0); }
    public static Vector3Int _zz1(this Vector3Int v) { return new Vector3Int(v.z, v.z, 1); }
    public static Vector3Int _z0x(this Vector3Int v) { return new Vector3Int(v.z, 0, v.x); }
    public static Vector3Int _z0y(this Vector3Int v) { return new Vector3Int(v.z, 0, v.y); }
    public static Vector3Int _z0z(this Vector3Int v) { return new Vector3Int(v.z, 0, v.z); }
    public static Vector3Int _z00(this Vector3Int v) { return new Vector3Int(v.z, 0, 0); }
    public static Vector3Int _z01(this Vector3Int v) { return new Vector3Int(v.z, 0, 1); }
    public static Vector3Int _z1x(this Vector3Int v) { return new Vector3Int(v.z, 1, v.x); }
    public static Vector3Int _z1y(this Vector3Int v) { return new Vector3Int(v.z, 1, v.y); }
    public static Vector3Int _z1z(this Vector3Int v) { return new Vector3Int(v.z, 1, v.z); }
    public static Vector3Int _z10(this Vector3Int v) { return new Vector3Int(v.z, 1, 0); }
    public static Vector3Int _z11(this Vector3Int v) { return new Vector3Int(v.z, 1, 1); }
    public static Vector3Int _0xx(this Vector3Int v) { return new Vector3Int(0, v.x, v.x); }
    public static Vector3Int _0xy(this Vector3Int v) { return new Vector3Int(0, v.x, v.y); }
    public static Vector3Int _0xz(this Vector3Int v) { return new Vector3Int(0, v.x, v.z); }
    public static Vector3Int _0x0(this Vector3Int v) { return new Vector3Int(0, v.x, 0); }
    public static Vector3Int _0x1(this Vector3Int v) { return new Vector3Int(0, v.x, 1); }
    public static Vector3Int _0yx(this Vector3Int v) { return new Vector3Int(0, v.y, v.x); }
    public static Vector3Int _0yy(this Vector3Int v) { return new Vector3Int(0, v.y, v.y); }
    public static Vector3Int _0yz(this Vector3Int v) { return new Vector3Int(0, v.y, v.z); }
    public static Vector3Int _0y0(this Vector3Int v) { return new Vector3Int(0, v.y, 0); }
    public static Vector3Int _0y1(this Vector3Int v) { return new Vector3Int(0, v.y, 1); }
    public static Vector3Int _0zx(this Vector3Int v) { return new Vector3Int(0, v.z, v.x); }
    public static Vector3Int _0zy(this Vector3Int v) { return new Vector3Int(0, v.z, v.y); }
    public static Vector3Int _0zz(this Vector3Int v) { return new Vector3Int(0, v.z, v.z); }
    public static Vector3Int _0z0(this Vector3Int v) { return new Vector3Int(0, v.z, 0); }
    public static Vector3Int _0z1(this Vector3Int v) { return new Vector3Int(0, v.z, 1); }
    public static Vector3Int _00x(this Vector3Int v) { return new Vector3Int(0, 0, v.x); }
    public static Vector3Int _00y(this Vector3Int v) { return new Vector3Int(0, 0, v.y); }
    public static Vector3Int _00z(this Vector3Int v) { return new Vector3Int(0, 0, v.z); }
    public static Vector3Int _000(this Vector3Int v) { return new Vector3Int(0, 0, 0); }
    public static Vector3Int _001(this Vector3Int v) { return new Vector3Int(0, 0, 1); }
    public static Vector3Int _01x(this Vector3Int v) { return new Vector3Int(0, 1, v.x); }
    public static Vector3Int _01y(this Vector3Int v) { return new Vector3Int(0, 1, v.y); }
    public static Vector3Int _01z(this Vector3Int v) { return new Vector3Int(0, 1, v.z); }
    public static Vector3Int _010(this Vector3Int v) { return new Vector3Int(0, 1, 0); }
    public static Vector3Int _011(this Vector3Int v) { return new Vector3Int(0, 1, 1); }
    public static Vector3Int _1xx(this Vector3Int v) { return new Vector3Int(1, v.x, v.x); }
    public static Vector3Int _1xy(this Vector3Int v) { return new Vector3Int(1, v.x, v.y); }
    public static Vector3Int _1xz(this Vector3Int v) { return new Vector3Int(1, v.x, v.z); }
    public static Vector3Int _1x0(this Vector3Int v) { return new Vector3Int(1, v.x, 0); }
    public static Vector3Int _1x1(this Vector3Int v) { return new Vector3Int(1, v.x, 1); }
    public static Vector3Int _1yx(this Vector3Int v) { return new Vector3Int(1, v.y, v.x); }
    public static Vector3Int _1yy(this Vector3Int v) { return new Vector3Int(1, v.y, v.y); }
    public static Vector3Int _1yz(this Vector3Int v) { return new Vector3Int(1, v.y, v.z); }
    public static Vector3Int _1y0(this Vector3Int v) { return new Vector3Int(1, v.y, 0); }
    public static Vector3Int _1y1(this Vector3Int v) { return new Vector3Int(1, v.y, 1); }
    public static Vector3Int _1zx(this Vector3Int v) { return new Vector3Int(1, v.z, v.x); }
    public static Vector3Int _1zy(this Vector3Int v) { return new Vector3Int(1, v.z, v.y); }
    public static Vector3Int _1zz(this Vector3Int v) { return new Vector3Int(1, v.z, v.z); }
    public static Vector3Int _1z0(this Vector3Int v) { return new Vector3Int(1, v.z, 0); }
    public static Vector3Int _1z1(this Vector3Int v) { return new Vector3Int(1, v.z, 1); }
    public static Vector3Int _10x(this Vector3Int v) { return new Vector3Int(1, 0, v.x); }
    public static Vector3Int _10y(this Vector3Int v) { return new Vector3Int(1, 0, v.y); }
    public static Vector3Int _10z(this Vector3Int v) { return new Vector3Int(1, 0, v.z); }
    public static Vector3Int _100(this Vector3Int v) { return new Vector3Int(1, 0, 0); }
    public static Vector3Int _101(this Vector3Int v) { return new Vector3Int(1, 0, 1); }
    public static Vector3Int _11x(this Vector3Int v) { return new Vector3Int(1, 1, v.x); }
    public static Vector3Int _11y(this Vector3Int v) { return new Vector3Int(1, 1, v.y); }
    public static Vector3Int _11z(this Vector3Int v) { return new Vector3Int(1, 1, v.z); }
    public static Vector3Int _110(this Vector3Int v) { return new Vector3Int(1, 1, 0); }
    public static Vector3Int _111(this Vector3Int v) { return new Vector3Int(1, 1, 1); }
}