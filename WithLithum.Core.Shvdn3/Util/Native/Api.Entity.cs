// Generated via ApiCodeGen

#pragma warning disable CS1591

namespace WithLithum.Core.Util.Native;
using GTA;
using GTA.Math;
using GTA.Native;
            
public static partial class Api
{
    // 0x7239B21A38F536BA
    /// <summary>
    /// Hash: 0x7239B21A38F536BA
    /// </summary>
    public static bool DOES_ENTITY_EXIST(uint entity) => Function.Call<bool>((Hash)0x7239B21A38F536BA,entity);

    // 0xDDE6DF5AE89981D2
    /// <summary>
    /// Hash: 0xDDE6DF5AE89981D2
    /// </summary>
    public static bool DOES_ENTITY_BELONG_TO_THIS_SCRIPT(uint entity,bool p1) => Function.Call<bool>((Hash)0xDDE6DF5AE89981D2,entity,p1);

    // 0x060D6E96F8B8E48D
    /// <summary>
    /// Hash: 0x060D6E96F8B8E48D
    /// </summary>
    public static bool DOES_ENTITY_HAVE_DRAWABLE(uint entity) => Function.Call<bool>((Hash)0x060D6E96F8B8E48D,entity);

    // 0xDA95EA3317CC5064
    /// <summary>
    /// Hash: 0xDA95EA3317CC5064
    /// </summary>
    public static bool DOES_ENTITY_HAVE_PHYSICS(uint entity) => Function.Call<bool>((Hash)0xDA95EA3317CC5064,entity);

    // 0x20B711662962B472
    /// <summary>
    /// Hash: 0x20B711662962B472
    /// </summary>
    public static bool HAS_ENTITY_ANIM_FINISHED(uint entity,string animDict,string animName,int p3) => Function.Call<bool>((Hash)0x20B711662962B472,entity,animDict,animName,p3);

    // 0x95EB9964FF5C5C65
    /// <summary>
    /// Hash: 0x95EB9964FF5C5C65
    /// </summary>
    public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(uint entity) => Function.Call<bool>((Hash)0x95EB9964FF5C5C65,entity);

    // 0x605F5A140F202491
    /// <summary>
    /// Hash: 0x605F5A140F202491
    /// </summary>
    public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(uint entity) => Function.Call<bool>((Hash)0x605F5A140F202491,entity);

    // 0xDFD5033FDBA0A9C8
    /// <summary>
    /// Hash: 0xDFD5033FDBA0A9C8
    /// </summary>
    public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(uint entity) => Function.Call<bool>((Hash)0xDFD5033FDBA0A9C8,entity);

    // 0xC86D67D52A707CF8
    /// <summary>
    /// Hash: 0xC86D67D52A707CF8
    /// </summary>
    public static bool HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(uint entity1,uint entity2,bool p2) => Function.Call<bool>((Hash)0xC86D67D52A707CF8,entity1,entity2,p2);

    // 0xFCDFF7B72D23A1AC
    /// <summary>
    /// Hash: 0xFCDFF7B72D23A1AC
    /// </summary>
    public static bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY(uint entity1,uint entity2,int traceType) => Function.Call<bool>((Hash)0xFCDFF7B72D23A1AC,entity1,entity2,traceType);

    // 0x394BDE2A7BBA031E
    /// <summary>
    /// Hash: 0x394BDE2A7BBA031E
    /// </summary>
    public static object _HAS_ENTITY_CLEAR_LOS_TO_ENTITY_2(uint entity1,uint entity2,int traceType) => Function.Call<object>((Hash)0x394BDE2A7BBA031E,entity1,entity2,traceType);

    // 0x0267D00AF114F17A
    /// <summary>
    /// Hash: 0x0267D00AF114F17A
    /// </summary>
    public static bool HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(uint entity1,uint entity2) => Function.Call<bool>((Hash)0x0267D00AF114F17A,entity1,entity2);

    // 0x8BAD02F0368D9E14
    /// <summary>
    /// Hash: 0x8BAD02F0368D9E14
    /// </summary>
    public static bool HAS_ENTITY_COLLIDED_WITH_ANYTHING(uint entity) => Function.Call<bool>((Hash)0x8BAD02F0368D9E14,entity);

    // 0x5C3D0A935F535C4C
    /// <summary>
    /// Hash: 0x5C3D0A935F535C4C
    /// </summary>
    public static uint GET_LAST_MATERIAL_HIT_BY_ENTITY(uint entity) => Function.Call<uint>((Hash)0x5C3D0A935F535C4C,entity);

    // 0xE465D4AB7CA6AE72
    /// <summary>
    /// Hash: 0xE465D4AB7CA6AE72
    /// </summary>
    public static Vector3 GET_COLLISION_NORMAL_OF_LAST_HIT_FOR_ENTITY(uint entity) => Function.Call<Vector3>((Hash)0xE465D4AB7CA6AE72,entity);

    // 0x40FDEDB72F8293B2
    /// <summary>
    /// Hash: 0x40FDEDB72F8293B2
    /// </summary>
    public static void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(uint entity) => Function.Call((Hash)0x40FDEDB72F8293B2,entity);

    // 0x346D81500D088F42
    /// <summary>
    /// Hash: 0x346D81500D088F42
    /// </summary>
    public static float GET_ENTITY_ANIM_CURRENT_TIME(uint entity,string animDict,string animName) => Function.Call<float>((Hash)0x346D81500D088F42,entity,animDict,animName);

    // 0x50BD2730B191E360
    /// <summary>
    /// Hash: 0x50BD2730B191E360
    /// </summary>
    public static float GET_ENTITY_ANIM_TOTAL_TIME(uint entity,string animDict,string animName) => Function.Call<float>((Hash)0x50BD2730B191E360,entity,animDict,animName);

    // 0xFEDDF04D62B8D790
    /// <summary>
    /// Hash: 0xFEDDF04D62B8D790
    /// </summary>
    public static float GET_ANIM_DURATION(string animDict,string animName) => Function.Call<float>((Hash)0xFEDDF04D62B8D790,animDict,animName);

    // 0x48C2BED9180FE123
    /// <summary>
    /// Hash: 0x48C2BED9180FE123
    /// </summary>
    public static Entity GET_ENTITY_ATTACHED_TO(uint entity) => Function.Call<Entity>((Hash)0x48C2BED9180FE123,entity);

    // 0x3FEF770D40960D5A
    /// <summary>
    /// Hash: 0x3FEF770D40960D5A
    /// </summary>
    public static Vector3 GET_ENTITY_COORDS(uint entity,bool alive) => Function.Call<Vector3>((Hash)0x3FEF770D40960D5A,entity,alive);

    // 0x0A794A5A57F8DF91
    /// <summary>
    /// Hash: 0x0A794A5A57F8DF91
    /// </summary>
    public static Vector3 GET_ENTITY_FORWARD_VECTOR(uint entity) => Function.Call<Vector3>((Hash)0x0A794A5A57F8DF91,entity);

    // 0x8BB4EF4214E0E6D5
    /// <summary>
    /// Hash: 0x8BB4EF4214E0E6D5
    /// </summary>
    public static float GET_ENTITY_FORWARD_X(uint entity) => Function.Call<float>((Hash)0x8BB4EF4214E0E6D5,entity);

    // 0x866A4A5FAE349510
    /// <summary>
    /// Hash: 0x866A4A5FAE349510
    /// </summary>
    public static float GET_ENTITY_FORWARD_Y(uint entity) => Function.Call<float>((Hash)0x866A4A5FAE349510,entity);

    // 0xE83D4F9BA2A38914
    /// <summary>
    /// Hash: 0xE83D4F9BA2A38914
    /// </summary>
    public static float GET_ENTITY_HEADING(uint entity) => Function.Call<float>((Hash)0xE83D4F9BA2A38914,entity);

    // 0x846BF6291198A71E
    /// <summary>
    /// Hash: 0x846BF6291198A71E
    /// </summary>
    public static float _GET_ENTITY_PHYSICS_HEADING(uint entity) => Function.Call<float>((Hash)0x846BF6291198A71E,entity);

    // 0xEEF059FAD016D209
    /// <summary>
    /// Hash: 0xEEF059FAD016D209
    /// </summary>
    public static int GET_ENTITY_HEALTH(uint entity) => Function.Call<int>((Hash)0xEEF059FAD016D209,entity);

    // 0x15D757606D170C3C
    /// <summary>
    /// Hash: 0x15D757606D170C3C
    /// </summary>
    public static int GET_ENTITY_MAX_HEALTH(uint entity) => Function.Call<int>((Hash)0x15D757606D170C3C,entity);

    // 0x166E7CF68597D8B5
    /// <summary>
    /// Hash: 0x166E7CF68597D8B5
    /// </summary>
    public static void SET_ENTITY_MAX_HEALTH(uint entity,int value) => Function.Call((Hash)0x166E7CF68597D8B5,entity,value);

    // 0x5A504562485944DD
    /// <summary>
    /// Hash: 0x5A504562485944DD
    /// </summary>
    public static float GET_ENTITY_HEIGHT(uint entity,float X,float Y,float Z,bool atTop,bool inWorldCoords) => Function.Call<float>((Hash)0x5A504562485944DD,entity,X,Y,Z,atTop,inWorldCoords);

    // 0x1DD55701034110E5
    /// <summary>
    /// Hash: 0x1DD55701034110E5
    /// </summary>
    public static float GET_ENTITY_HEIGHT_ABOVE_GROUND(uint entity) => Function.Call<float>((Hash)0x1DD55701034110E5,entity);

    // 0x9F47B058362C84B5
    /// <summary>
    /// Hash: 0x9F47B058362C84B5
    /// </summary>
    public static uint GET_ENTITY_MODEL(uint entity) => Function.Call<uint>((Hash)0x9F47B058362C84B5,entity);

    // 0x2274BC1C4885E333
    /// <summary>
    /// Hash: 0x2274BC1C4885E333
    /// </summary>
    public static Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(uint entity,float posX,float posY,float posZ) => Function.Call<Vector3>((Hash)0x2274BC1C4885E333,entity,posX,posY,posZ);

    // 0x1899F328B0E12848
    /// <summary>
    /// Hash: 0x1899F328B0E12848
    /// </summary>
    public static Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(uint entity,float offsetX,float offsetY,float offsetZ) => Function.Call<Vector3>((Hash)0x1899F328B0E12848,entity,offsetX,offsetY,offsetZ);

    // 0xD45DC2893621E1FE
    /// <summary>
    /// Hash: 0xD45DC2893621E1FE
    /// </summary>
    public static float GET_ENTITY_PITCH(uint entity) => Function.Call<float>((Hash)0xD45DC2893621E1FE,entity);

    // 0x831E0242595560DF
    /// <summary>
    /// Hash: 0x831E0242595560DF
    /// </summary>
    public static float GET_ENTITY_ROLL(uint entity) => Function.Call<float>((Hash)0x831E0242595560DF,entity);

    // 0xAFBD61CC738D9EB9
    /// <summary>
    /// Hash: 0xAFBD61CC738D9EB9
    /// </summary>
    public static Vector3 GET_ENTITY_ROTATION(uint entity,int rotationOrder) => Function.Call<Vector3>((Hash)0xAFBD61CC738D9EB9,entity,rotationOrder);

    // 0x213B91045D09B983
    /// <summary>
    /// Hash: 0x213B91045D09B983
    /// </summary>
    public static Vector3 GET_ENTITY_ROTATION_VELOCITY(uint entity) => Function.Call<Vector3>((Hash)0x213B91045D09B983,entity);
    
    // 0xD5037BA82E12416F
    /// <summary>
    /// Hash: 0xD5037BA82E12416F
    /// </summary>
    public static float GET_ENTITY_SPEED(uint entity) => Function.Call<float>((Hash)0xD5037BA82E12416F,entity);

    // 0x9A8D700A51CB7B0D
    /// <summary>
    /// Hash: 0x9A8D700A51CB7B0D
    /// </summary>
    public static Vector3 GET_ENTITY_SPEED_VECTOR(uint entity,bool relative) => Function.Call<Vector3>((Hash)0x9A8D700A51CB7B0D,entity,relative);

    // 0x95EED5A694951F9F
    /// <summary>
    /// Hash: 0x95EED5A694951F9F
    /// </summary>
    public static float GET_ENTITY_UPRIGHT_VALUE(uint entity) => Function.Call<float>((Hash)0x95EED5A694951F9F,entity);

    // 0x4805D2B1D8CF94A9
    /// <summary>
    /// Hash: 0x4805D2B1D8CF94A9
    /// </summary>
    public static Vector3 GET_ENTITY_VELOCITY(uint entity) => Function.Call<Vector3>((Hash)0x4805D2B1D8CF94A9,entity);

    // 0xD7E3B9735C0F89D6
    /// <summary>
    /// Hash: 0xD7E3B9735C0F89D6
    /// </summary>
    public static uint GET_OBJECT_INDEX_FROM_ENTITY_INDEX(uint entity) => Function.Call<uint>((Hash)0xD7E3B9735C0F89D6,entity);

    // 0x04A2A40C73395041
    /// <summary>
    /// Hash: 0x04A2A40C73395041
    /// </summary>
    public static uint GET_PED_INDEX_FROM_ENTITY_INDEX(uint entity) => Function.Call<uint>((Hash)0x04A2A40C73395041,entity);

    // 0x4B53F92932ADFAC0
    /// <summary>
    /// Hash: 0x4B53F92932ADFAC0
    /// </summary>
    public static uint GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(uint entity) => Function.Call<uint>((Hash)0x4B53F92932ADFAC0,entity);

    // 0x44A8FCB8ED227738
    /// <summary>
    /// Hash: 0x44A8FCB8ED227738
    /// </summary>
    public static Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(uint entity,int boneIndex) => Function.Call<Vector3>((Hash)0x44A8FCB8ED227738,entity,boneIndex);

    // 0x7196842CB375CDB3
    /// <summary>
    /// Hash: 0x7196842CB375CDB3
    /// </summary>
    public static Player GET_NEAREST_PLAYER_TO_ENTITY(uint entity) => Function.Call<Player>((Hash)0x7196842CB375CDB3,entity);

    // 0x4DC9A62F844D9337
    /// <summary>
    /// Hash: 0x4DC9A62F844D9337
    /// </summary>
    public static Player GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(uint entity,int team) => Function.Call<Player>((Hash)0x4DC9A62F844D9337,entity,team);

    // 0x8ACD366038D14505
    /// <summary>
    /// Hash: 0x8ACD366038D14505
    /// </summary>
    public static int GET_ENTITY_TYPE(uint entity) => Function.Call<int>((Hash)0x8ACD366038D14505,entity);

    // 0xF6F5161F4534EDFF
    /// <summary>
    /// Hash: 0xF6F5161F4534EDFF
    /// </summary>
    public static int GET_ENTITY_POPULATION_TYPE(uint entity) => Function.Call<int>((Hash)0xF6F5161F4534EDFF,entity);

    // 0x524AC5ECEA15343E
    /// <summary>
    /// Hash: 0x524AC5ECEA15343E
    /// </summary>
    public static bool IS_ENTITY_A_PED(uint entity) => Function.Call<bool>((Hash)0x524AC5ECEA15343E,entity);

    // 0x0A7B270912999B3C
    /// <summary>
    /// Hash: 0x0A7B270912999B3C
    /// </summary>
    public static bool IS_ENTITY_A_MISSION_ENTITY(uint entity) => Function.Call<bool>((Hash)0x0A7B270912999B3C,entity);

    // 0x6AC7003FA6E5575E
    /// <summary>
    /// Hash: 0x6AC7003FA6E5575E
    /// </summary>
    public static bool IS_ENTITY_A_VEHICLE(uint entity) => Function.Call<bool>((Hash)0x6AC7003FA6E5575E,entity);

    // 0x8D68C8FD0FACA94E
    /// <summary>
    /// Hash: 0x8D68C8FD0FACA94E
    /// </summary>
    public static bool IS_ENTITY_AN_OBJECT(uint entity) => Function.Call<bool>((Hash)0x8D68C8FD0FACA94E,entity);

    // 0x20B60995556D004F
    /// <summary>
    /// Hash: 0x20B60995556D004F
    /// </summary>
    public static bool IS_ENTITY_AT_COORD(uint entity,float xPos,float yPos,float zPos,float xSize,float ySize,float zSize,bool p7,bool p8,int p9) => Function.Call<bool>((Hash)0x20B60995556D004F,entity,xPos,yPos,zPos,xSize,ySize,zSize,p7,p8,p9);

    // 0x751B70C3D034E187
    /// <summary>
    /// Hash: 0x751B70C3D034E187
    /// </summary>
    public static bool IS_ENTITY_AT_ENTITY(uint entity1,uint entity2,float xSize,float ySize,float zSize,bool p5,bool p6,int p7) => Function.Call<bool>((Hash)0x751B70C3D034E187,entity1,entity2,xSize,ySize,zSize,p5,p6,p7);

    // 0xB346476EF1A64897
    /// <summary>
    /// Hash: 0xB346476EF1A64897
    /// </summary>
    public static bool IS_ENTITY_ATTACHED(uint entity) => Function.Call<bool>((Hash)0xB346476EF1A64897,entity);

    // 0xCF511840CEEDE0CC
    /// <summary>
    /// Hash: 0xCF511840CEEDE0CC
    /// </summary>
    public static bool IS_ENTITY_ATTACHED_TO_ANY_OBJECT(uint entity) => Function.Call<bool>((Hash)0xCF511840CEEDE0CC,entity);

    // 0xB1632E9A5F988D11
    /// <summary>
    /// Hash: 0xB1632E9A5F988D11
    /// </summary>
    public static bool IS_ENTITY_ATTACHED_TO_ANY_PED(uint entity) => Function.Call<bool>((Hash)0xB1632E9A5F988D11,entity);

    // 0x26AA915AD89BFB4B
    /// <summary>
    /// Hash: 0x26AA915AD89BFB4B
    /// </summary>
    public static bool IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(uint entity) => Function.Call<bool>((Hash)0x26AA915AD89BFB4B,entity);

    // 0xEFBE71898A993728
    /// <summary>
    /// Hash: 0xEFBE71898A993728
    /// </summary>
    public static bool IS_ENTITY_ATTACHED_TO_ENTITY(Entity from,Entity to) => Function.Call<bool>((Hash)0xEFBE71898A993728,from,to);

    // 0x5F9532F3B5CC2551
    /// <summary>
    /// Hash: 0x5F9532F3B5CC2551
    /// </summary>
    public static bool IS_ENTITY_DEAD(uint entity,bool p1) => Function.Call<bool>((Hash)0x5F9532F3B5CC2551,entity,p1);

    // 0x886E37EC497200B6
    /// <summary>
    /// Hash: 0x886E37EC497200B6
    /// </summary>
    public static bool IS_ENTITY_IN_AIR(uint entity) => Function.Call<bool>((Hash)0x886E37EC497200B6,entity);

    // 0x51210CED3DA1C78A
    /// <summary>
    /// Hash: 0x51210CED3DA1C78A
    /// </summary>
    public static bool IS_ENTITY_IN_ANGLED_AREA(uint entity,float x1,float y1,float z1,float x2,float y2,float z2,float width,bool debug,bool includeZ,object p10) => Function.Call<bool>((Hash)0x51210CED3DA1C78A,entity,x1,y1,z1,x2,y2,z2,width,debug,includeZ,null);

    // 0x54736AA40E271165
    /// <summary>
    /// Hash: 0x54736AA40E271165
    /// </summary>
    public static bool IS_ENTITY_IN_AREA(uint entity,float x1,float y1,float z1,float x2,float y2,float z2,bool p7,bool p8,object p9) => Function.Call<bool>((Hash)0x54736AA40E271165,entity,x1,y1,z1,x2,y2,z2,p7,p8,null);

    // 0xB6463CF6AF527071
    /// <summary>
    /// Hash: 0xB6463CF6AF527071
    /// </summary>
    public static bool IS_ENTITY_IN_ZONE(uint entity,string zone) => Function.Call<bool>((Hash)0xB6463CF6AF527071,entity,zone);

    // 0xCFB0A0D8EDD145A3
    /// <summary>
    /// Hash: 0xCFB0A0D8EDD145A3
    /// </summary>
    public static bool IS_ENTITY_IN_WATER(uint entity) => Function.Call<bool>((Hash)0xCFB0A0D8EDD145A3,entity);

    // 0xE81AFC1BC4CC41CE
    /// <summary>
    /// Hash: 0xE81AFC1BC4CC41CE
    /// </summary>
    public static float GET_ENTITY_SUBMERGED_LEVEL(uint entity) => Function.Call<float>((Hash)0xE81AFC1BC4CC41CE,entity);

    // 0x694E00132F2823ED
    /// <summary>
    /// Hash: 0x694E00132F2823ED
    /// </summary>
    public static void _0x694E00132F2823ED(uint entity,bool toggle) => Function.Call((Hash)0x694E00132F2823ED,entity,toggle);

    // 0xE659E47AF827484B
    /// <summary>
    /// Hash: 0xE659E47AF827484B
    /// </summary>
    public static bool IS_ENTITY_ON_SCREEN(uint entity) => Function.Call<bool>((Hash)0xE659E47AF827484B,entity);

    // 0x1F0B79228E461EC9
    /// <summary>
    /// Hash: 0x1F0B79228E461EC9
    /// </summary>
    public static bool IS_ENTITY_PLAYING_ANIM(uint entity,string animDict,string animName,int taskFlag) => Function.Call<bool>((Hash)0x1F0B79228E461EC9,entity,animDict,animName,taskFlag);

    // 0x1218E6886D3D8327
    /// <summary>
    /// Hash: 0x1218E6886D3D8327
    /// </summary>
    public static bool IS_ENTITY_STATIC(uint entity) => Function.Call<bool>((Hash)0x1218E6886D3D8327,entity);

    // 0x17FFC1B2BA35A494
    /// <summary>
    /// Hash: 0x17FFC1B2BA35A494
    /// </summary>
    public static bool IS_ENTITY_TOUCHING_ENTITY(uint entity,Entity targetEntity) => Function.Call<bool>((Hash)0x17FFC1B2BA35A494,entity,targetEntity);

    // 0x0F42323798A58C8C
    /// <summary>
    /// Hash: 0x0F42323798A58C8C
    /// </summary>
    public static bool IS_ENTITY_TOUCHING_MODEL(uint entity,uint modelHash) => Function.Call<bool>((Hash)0x0F42323798A58C8C,entity,modelHash);

    // 0x5333F526F6AB19AA
    /// <summary>
    /// Hash: 0x5333F526F6AB19AA
    /// </summary>
    public static bool IS_ENTITY_UPRIGHT(uint entity,float angle) => Function.Call<bool>((Hash)0x5333F526F6AB19AA,entity,angle);

    // 0x1DBD58820FA61D71
    /// <summary>
    /// Hash: 0x1DBD58820FA61D71
    /// </summary>
    public static bool IS_ENTITY_UPSIDEDOWN(uint entity) => Function.Call<bool>((Hash)0x1DBD58820FA61D71,entity);

    // 0x47D6F43D77935C75
    /// <summary>
    /// Hash: 0x47D6F43D77935C75
    /// </summary>
    public static bool IS_ENTITY_VISIBLE(uint entity) => Function.Call<bool>((Hash)0x47D6F43D77935C75,entity);

    // 0xD796CB5BA8F20E32
    /// <summary>
    /// Hash: 0xD796CB5BA8F20E32
    /// </summary>
    public static bool IS_ENTITY_VISIBLE_TO_SCRIPT(uint entity) => Function.Call<bool>((Hash)0xD796CB5BA8F20E32,entity);

    // 0xE31C2C72B8692B64
    /// <summary>
    /// Hash: 0xE31C2C72B8692B64
    /// </summary>
    public static bool IS_ENTITY_OCCLUDED(uint entity) => Function.Call<bool>((Hash)0xE31C2C72B8692B64,entity);

    // 0xEE5D2A122E09EC42
    /// <summary>
    /// Hash: 0xEE5D2A122E09EC42
    /// </summary>
    public static bool WOULD_ENTITY_BE_OCCLUDED(uint entityModelHash,float x,float y,float z,bool p4) => Function.Call<bool>((Hash)0xEE5D2A122E09EC42,entityModelHash,x,y,z,p4);

    // 0xD05BFF0C0A12C68F
    /// <summary>
    /// Hash: 0xD05BFF0C0A12C68F
    /// </summary>
    public static bool IS_ENTITY_WAITING_FOR_WORLD_COLLISION(uint entity) => Function.Call<bool>((Hash)0xD05BFF0C0A12C68F,entity);

    // 0x18FF00FC7EFF559E
    /// <summary>
    /// Hash: 0x18FF00FC7EFF559E
    /// </summary>
    public static void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(uint entity,int forceType,float x,float y,float z,bool p5,bool isDirectionRel,bool isForceRel,bool p8) => Function.Call((Hash)0x18FF00FC7EFF559E,entity,forceType,x,y,z,p5,isDirectionRel,isForceRel,p8);

    // 0xC5F68BE9613E2D18
    /// <summary>
    /// Hash: 0xC5F68BE9613E2D18
    /// </summary>
    public static void APPLY_FORCE_TO_ENTITY(uint entity,int forceFlags,float x,float y,float z,float offX,float offY,float offZ,int boneIndex,bool isDirectionRel,bool ignoreUpVec,bool isForceRel,bool p12,bool p13) => Function.Call((Hash)0xC5F68BE9613E2D18,entity,forceFlags,x,y,z,offX,offY,offZ,boneIndex,isDirectionRel,ignoreUpVec,isForceRel,p12,p13);

    // 0x6B9BBD38AB0796DF
    /// <summary>
    /// Hash: 0x6B9BBD38AB0796DF
    /// </summary>
    public static void ATTACH_ENTITY_TO_ENTITY(uint entity1,uint entity2,int boneIndex,float xPos,float yPos,float zPos,float xRot,float yRot,float zRot,bool p9,bool useSoftPinning,bool collision,bool isPed,int vertexIndex,bool fixedRot) => Function.Call((Hash)0x6B9BBD38AB0796DF,entity1,entity2,boneIndex,xPos,yPos,zPos,xRot,yRot,zRot,p9,useSoftPinning,collision,isPed,vertexIndex,fixedRot);

    // 0x5C48B75732C8456C
    /// <summary>
    /// Hash: 0x5C48B75732C8456C
    /// </summary>
    public static void _ATTACH_ENTITY_BONE_TO_ENTITY_BONE(uint entity1,uint entity2,int boneIndex1,int boneIndex2,bool p4,bool p5) => Function.Call((Hash)0x5C48B75732C8456C,entity1,entity2,boneIndex1,boneIndex2,p4,p5);

    // 0xFD1695C5D3B05439
    /// <summary>
    /// Hash: 0xFD1695C5D3B05439
    /// </summary>
    public static void _ATTACH_ENTITY_BONE_TO_ENTITY_BONE_PHYSICALLY(uint entity1,uint entity2,int boneIndex1,int boneIndex2,bool p4,bool p5) => Function.Call((Hash)0xFD1695C5D3B05439,entity1,entity2,boneIndex1,boneIndex2,p4,p5);

    // 0xC3675780C92F90F9
    /// <summary>
    /// Hash: 0xC3675780C92F90F9
    /// </summary>
    public static void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(uint entity1,uint entity2,int boneIndex1,int boneIndex2,float xPos1,float yPos1,float zPos1,float xPos2,float yPos2,float zPos2,float xRot,float yRot,float zRot,float breakForce,bool fixedRot,bool p15,bool collision,bool p17,int p18) => Function.Call((Hash)0xC3675780C92F90F9,entity1,entity2,boneIndex1,boneIndex2,xPos1,yPos1,zPos1,xPos2,yPos2,zPos2,xRot,yRot,zRot,breakForce,fixedRot,p15,collision,p17,p18);

    // 0xF4080490ADC51C6F
    /// <summary>
    /// Hash: 0xF4080490ADC51C6F
    /// </summary>
    public static void PROCESS_ENTITY_ATTACHMENTS(uint entity) => Function.Call((Hash)0xF4080490ADC51C6F,entity);

    // 0xFB71170B7E76ACBA
    /// <summary>
    /// Hash: 0xFB71170B7E76ACBA
    /// </summary>
    public static int GET_ENTITY_BONE_INDEX_BY_NAME(uint entity,string boneName) => Function.Call<int>((Hash)0xFB71170B7E76ACBA,entity,boneName);

    // 0xA72CD9CA74A5ECBA
    /// <summary>
    /// Hash: 0xA72CD9CA74A5ECBA
    /// </summary>
    public static void CLEAR_ENTITY_LAST_DAMAGE_ENTITY(uint entity) => Function.Call((Hash)0xA72CD9CA74A5ECBA,entity);

    // 0xAE3CBE5BF394C9C9
    /// <summary>
    /// Hash: 0xAE3CBE5BF394C9C9
    /// </summary>
    public static unsafe void DELETE_ENTITY(ref uint entity)
    {
        var rf = entity;
        Function.Call(Hash.DELETE_ENTITY, &rf);
        entity = rf;
    }

    // 0x961AC54BF0613F5D
    /// <summary>
    /// Hash: 0x961AC54BF0613F5D
    /// </summary>
    public static void DETACH_ENTITY(uint entity,bool dynamic,bool collision) => Function.Call((Hash)0x961AC54BF0613F5D,entity,dynamic,collision);

    // 0x428CA6DBD1094446
    /// <summary>
    /// Hash: 0x428CA6DBD1094446
    /// </summary>
    public static void FREEZE_ENTITY_POSITION(uint entity,bool toggle) => Function.Call((Hash)0x428CA6DBD1094446,entity,toggle);

    // 0x3910051CCECDB00C
    /// <summary>
    /// Hash: 0x3910051CCECDB00C
    /// </summary>
    public static void _SET_ENTITY_CLEANUP_BY_ENGINE(uint entity,bool toggle) => Function.Call((Hash)0x3910051CCECDB00C,entity,toggle);

    // 0x7FB218262B810701
    /// <summary>
    /// Hash: 0x7FB218262B810701
    /// </summary>
    public static bool PLAY_ENTITY_ANIM(uint entity,string animName,string animDict,float p3,bool loop,bool stayInAnim,bool p6,float delta,object bitset) => Function.Call<bool>((Hash)0x7FB218262B810701,entity,animName,animDict,p3,loop,stayInAnim,p6,delta,null);

    // 0xC77720A12FE14A86
    /// <summary>
    /// Hash: 0xC77720A12FE14A86
    /// </summary>
    public static bool PLAY_SYNCHRONIZED_ENTITY_ANIM(uint entity,int syncedScene,string animation,string propName,float p4,float p5,object p6,float p7) => Function.Call<bool>((Hash)0xC77720A12FE14A86,entity,syncedScene,animation,propName,p4,p5,null,p7);

    // 0x11E79CAB7183B6F5
    /// <summary>
    /// Hash: 0x11E79CAB7183B6F5
    /// </summary>
    public static bool STOP_SYNCHRONIZED_MAP_ENTITY_ANIM(float p0,float p1,float p2,float p3,object p4,float p5) => Function.Call<bool>((Hash)0x11E79CAB7183B6F5,p0,p1,p2,p3,null,p5);

    // 0x28004F88151E03E0
    /// <summary>
    /// Hash: 0x28004F88151E03E0
    /// </summary>
    public static object STOP_ENTITY_ANIM(uint entity,string animation,string animGroup,float p3) => Function.Call<object>((Hash)0x28004F88151E03E0,entity,animation,animGroup,p3);

    // 0x43D3807C077261E3
    /// <summary>
    /// Hash: 0x43D3807C077261E3
    /// </summary>
    public static bool STOP_SYNCHRONIZED_ENTITY_ANIM(uint entity,float p1,bool p2) => Function.Call<bool>((Hash)0x43D3807C077261E3,entity,p1,p2);

    // 0xEAF4CD9EA3E7E922
    /// <summary>
    /// Hash: 0xEAF4CD9EA3E7E922
    /// </summary>
    public static bool HAS_ANIM_EVENT_FIRED(uint entity,uint actionHash) => Function.Call<bool>((Hash)0xEAF4CD9EA3E7E922,entity,actionHash);

    // 0x4487C259F0F70977
    /// <summary>
    /// Hash: 0x4487C259F0F70977
    /// </summary>
    public static void SET_ENTITY_ANIM_CURRENT_TIME(uint entity,string animDictionary,string animName,float time) => Function.Call((Hash)0x4487C259F0F70977,entity,animDictionary,animName,time);

    // 0x28D1A16553C51776
    /// <summary>
    /// Hash: 0x28D1A16553C51776
    /// </summary>
    public static void SET_ENTITY_ANIM_SPEED(uint entity,string animDictionary,string animName,float speedMultiplier) => Function.Call((Hash)0x28D1A16553C51776,entity,animDictionary,animName,speedMultiplier);

    // 0xAD738C3085FE7E11
    /// <summary>
    /// Hash: 0xAD738C3085FE7E11
    /// </summary>
    public static void SET_ENTITY_AS_MISSION_ENTITY(uint entity,bool p1,bool p2) => Function.Call((Hash)0xAD738C3085FE7E11,entity,p1,p2);

    // 0xB736A491E64A32CF
    /// <summary>
    /// Hash: 0xB736A491E64A32CF
    /// </summary>
    public static unsafe void SET_ENTITY_AS_NO_LONGER_NEEDED(ref uint entity)
    {
        var ent = entity;
        Function.Call(Hash.SET_ENTITY_AS_NO_LONGER_NEEDED, &ent);
        entity = ent;
    }

    // 0x2595DD4236549CE3
    /// <summary>
    /// Hash: 0x2595DD4236549CE3
    /// </summary>
    public static unsafe void SET_PED_AS_NO_LONGER_NEEDED(ref uint ped)
    {
        var nped = ped;
        Function.Call((Hash)0x2595DD4236549CE3, &nped);
        ped = nped;
    }

    // 0x629BFA74418D6239
    /// <summary>
    /// Hash: 0x629BFA74418D6239
    /// </summary>
    public static unsafe void SET_VEHICLE_AS_NO_LONGER_NEEDED(ref uint vehicle)
    {
        var nv = vehicle;
        Function.Call((Hash)0x629BFA74418D6239, &nv);
        vehicle = nv;
    }

    // 0x3AE22DEB5BA5A3E6
    /// <summary>
    /// Hash: 0x3AE22DEB5BA5A3E6
    /// </summary>
    public static unsafe void SET_OBJECT_AS_NO_LONGER_NEEDED(ref uint obj)
    {
        var nv = obj;
        Function.Call((Hash)0x3AE22DEB5BA5A3E6, &nv);
        obj = nv;
    }

    // 0x1760FFA8AB074D66
    /// <summary>
    /// Hash: 0x1760FFA8AB074D66
    /// </summary>
    public static void SET_ENTITY_CAN_BE_DAMAGED(uint entity,bool toggle) => Function.Call((Hash)0x1760FFA8AB074D66,entity,toggle);

    // 0xD95CC5D2AB15A09F
    /// <summary>
    /// Hash: 0xD95CC5D2AB15A09F
    /// </summary>
    public static bool _GET_ENTITY_CAN_BE_DAMAGED(uint entity) => Function.Call<bool>((Hash)0xD95CC5D2AB15A09F,entity);

    // 0xE22D8FDE858B8119
    /// <summary>
    /// Hash: 0xE22D8FDE858B8119
    /// </summary>
    public static void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(uint entity,bool bCanBeDamaged,int relGroup) => Function.Call((Hash)0xE22D8FDE858B8119,entity,bCanBeDamaged,relGroup);

    // 0xD3997889736FD899
    /// <summary>
    /// Hash: 0xD3997889736FD899
    /// </summary>
    public static void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(uint entity,bool toggle) => Function.Call((Hash)0xD3997889736FD899,entity,toggle);

    // 0x1A9205C1B9EE827F
    /// <summary>
    /// Hash: 0x1A9205C1B9EE827F
    /// </summary>
    public static void SET_ENTITY_COLLISION(uint entity,bool toggle,bool keepPhysics) => Function.Call((Hash)0x1A9205C1B9EE827F,entity,toggle,keepPhysics);

    // 0xCCF1E97BEFDAE480
    /// <summary>
    /// Hash: 0xCCF1E97BEFDAE480
    /// </summary>
    public static bool GET_ENTITY_COLLISION_DISABLED(uint entity) => Function.Call<bool>((Hash)0xCCF1E97BEFDAE480,entity);

    // 0x9EBC85ED0FFFE51C
    /// <summary>
    /// Hash: 0x9EBC85ED0FFFE51C
    /// </summary>
    public static void SET_ENTITY_COMPLETELY_DISABLE_COLLISION(uint entity,bool toggle,bool keepPhysics) => Function.Call((Hash)0x9EBC85ED0FFFE51C,entity,toggle,keepPhysics);

    // 0x06843DA7060A026B
    /// <summary>
    /// Hash: 0x06843DA7060A026B
    /// </summary>
    public static void SET_ENTITY_COORDS(uint entity,float xPos,float yPos,float zPos,bool xAxis,bool yAxis,bool zAxis,bool clearArea) => Function.Call((Hash)0x06843DA7060A026B,entity,xPos,yPos,zPos,xAxis,yAxis,zAxis,clearArea);

    // 0x621873ECE1178967
    /// <summary>
    /// Hash: 0x621873ECE1178967
    /// </summary>
    public static void SET_ENTITY_COORDS_WITHOUT_PLANTS_RESET(uint entity,float xPos,float yPos,float zPos,bool alive,bool deadFlag,bool ragdollFlag,bool clearArea) => Function.Call((Hash)0x621873ECE1178967,entity,xPos,yPos,zPos,alive,deadFlag,ragdollFlag,clearArea);

    // 0x239A3351AC1DA385
    /// <summary>
    /// Hash: 0x239A3351AC1DA385
    /// </summary>
    public static void SET_ENTITY_COORDS_NO_OFFSET(uint entity,float xPos,float yPos,float zPos,bool xAxis,bool yAxis,bool zAxis) => Function.Call((Hash)0x239A3351AC1DA385,entity,xPos,yPos,zPos,xAxis,yAxis,zAxis);

    // 0x1718DE8E3F2823CA
    /// <summary>
    /// Hash: 0x1718DE8E3F2823CA
    /// </summary>
    public static void SET_ENTITY_DYNAMIC(uint entity,bool toggle) => Function.Call((Hash)0x1718DE8E3F2823CA,entity,toggle);

    // 0x8E2530AA8ADA980E
    /// <summary>
    /// Hash: 0x8E2530AA8ADA980E
    /// </summary>
    public static void SET_ENTITY_HEADING(uint entity,float heading) => Function.Call((Hash)0x8E2530AA8ADA980E,entity,heading);

    // 0x6B76DC1F3AE6E6A3
    /// <summary>
    /// Hash: 0x6B76DC1F3AE6E6A3
    /// </summary>
    public static void SET_ENTITY_HEALTH(uint entity,int health,int p2) => Function.Call((Hash)0x6B76DC1F3AE6E6A3,entity,health,p2);

    // 0x3882114BDE571AD4
    /// <summary>
    /// Hash: 0x3882114BDE571AD4
    /// </summary>
    public static void SET_ENTITY_INVINCIBLE(uint entity,bool toggle) => Function.Call((Hash)0x3882114BDE571AD4,entity,toggle);

    // 0xEA02E132F5C68722
    /// <summary>
    /// Hash: 0xEA02E132F5C68722
    /// </summary>
    public static void SET_ENTITY_IS_TARGET_PRIORITY(uint entity,bool p1,float p2) => Function.Call((Hash)0xEA02E132F5C68722,entity,p1,p2);

    // 0x7CFBA6A80BDF3874
    /// <summary>
    /// Hash: 0x7CFBA6A80BDF3874
    /// </summary>
    public static void SET_ENTITY_LIGHTS(uint entity,bool toggle) => Function.Call((Hash)0x7CFBA6A80BDF3874,entity,toggle);

    // 0x0DC7CABAB1E9B67E
    /// <summary>
    /// Hash: 0x0DC7CABAB1E9B67E
    /// </summary>
    public static void SET_ENTITY_LOAD_COLLISION_FLAG(uint entity,bool toggle,object p2) => Function.Call((Hash)0x0DC7CABAB1E9B67E,entity,toggle,0);

    // 0xE9676F61BC0B3321
    /// <summary>
    /// Hash: 0xE9676F61BC0B3321
    /// </summary>
    public static bool HAS_COLLISION_LOADED_AROUND_ENTITY(uint entity) => Function.Call<bool>((Hash)0xE9676F61BC0B3321,entity);

    // 0x0E46A3FCBDE2A1B1
    /// <summary>
    /// Hash: 0x0E46A3FCBDE2A1B1
    /// </summary>
    public static void SET_ENTITY_MAX_SPEED(uint entity,float speed) => Function.Call((Hash)0x0E46A3FCBDE2A1B1,entity,speed);

    // 0x79F020FF9EDC0748
    /// <summary>
    /// Hash: 0x79F020FF9EDC0748
    /// </summary>
    public static void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(uint entity,bool toggle) => Function.Call((Hash)0x79F020FF9EDC0748,entity,toggle);

    // 0x7022BD828FA0B082
    /// <summary>
    /// Hash: 0x7022BD828FA0B082
    /// </summary>
    public static void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(uint entity,bool p1,object p2) => Function.Call((Hash)0x7022BD828FA0B082,entity,p1,0);

    // 0xFAEE099C6F890BB8
    /// <summary>
    /// Hash: 0xFAEE099C6F890BB8
    /// </summary>
    public static void SET_ENTITY_PROOFS(uint entity,bool bulletProof,bool fireProof,bool explosionProof,bool collisionProof,bool meleeProof,bool p6,bool p7,bool drownProof) => Function.Call((Hash)0xFAEE099C6F890BB8,entity,bulletProof,fireProof,explosionProof,collisionProof,meleeProof,p6,p7,drownProof);

    // 0x77B21BE7AC540F07
    /// <summary>
    /// Hash: 0x77B21BE7AC540F07
    /// </summary>
    public static void SET_ENTITY_QUATERNION(uint entity,float x,float y,float z,float w) => Function.Call((Hash)0x77B21BE7AC540F07,entity,x,y,z,w);

    // 0x0A50A1EEDAD01E65
    /// <summary>
    /// Hash: 0x0A50A1EEDAD01E65
    /// </summary>
    public static void SET_ENTITY_RECORDS_COLLISIONS(uint entity,bool toggle) => Function.Call((Hash)0x0A50A1EEDAD01E65,entity,toggle);

    // 0x8524A8B0171D5E07
    /// <summary>
    /// Hash: 0x8524A8B0171D5E07
    /// </summary>
    public static void SET_ENTITY_ROTATION(uint entity,float pitch,float roll,float yaw,int rotationOrder,bool p5) => Function.Call((Hash)0x8524A8B0171D5E07,entity,pitch,roll,yaw,rotationOrder,p5);

    // 0xEA1C610A04DB6BBB
    /// <summary>
    /// Hash: 0xEA1C610A04DB6BBB
    /// </summary>
    public static void SET_ENTITY_VISIBLE(uint entity,bool toggle,bool unk) => Function.Call((Hash)0xEA1C610A04DB6BBB,entity,toggle,unk);

    // 0xC34BC448DA29F5E9
    /// <summary>
    /// Hash: 0xC34BC448DA29F5E9
    /// </summary>
    public static void _0xC34BC448DA29F5E9(uint entity,bool toggle) => Function.Call((Hash)0xC34BC448DA29F5E9,entity,toggle);

    // 0xE66377CDDADA4810
    /// <summary>
    /// Hash: 0xE66377CDDADA4810
    /// </summary>
    public static void _0xE66377CDDADA4810(uint entity,bool p1) => Function.Call((Hash)0xE66377CDDADA4810,entity,p1);

    // 0x1C99BB7B6E96D16F
    /// <summary>
    /// Hash: 0x1C99BB7B6E96D16F
    /// </summary>
    public static void SET_ENTITY_VELOCITY(uint entity,float x,float y,float z) => Function.Call((Hash)0x1C99BB7B6E96D16F,entity,x,y,z);

    // 0x8339643499D1222E
    /// <summary>
    /// Hash: 0x8339643499D1222E
    /// </summary>
    public static void _SET_ENTITY_ANGULAR_VELOCITY(uint entity,float x,float y,float z) => Function.Call((Hash)0x8339643499D1222E,entity,x,y,z);

    // 0x4A4722448F18EEF5
    /// <summary>
    /// Hash: 0x4A4722448F18EEF5
    /// </summary>
    public static void SET_ENTITY_HAS_GRAVITY(uint entity,bool toggle) => Function.Call((Hash)0x4A4722448F18EEF5,entity,toggle);

    // 0x5927F96A78577363
    /// <summary>
    /// Hash: 0x5927F96A78577363
    /// </summary>
    public static void SET_ENTITY_LOD_DIST(uint entity,int value) => Function.Call((Hash)0x5927F96A78577363,entity,value);

    // 0x4159C2762B5791D6
    /// <summary>
    /// Hash: 0x4159C2762B5791D6
    /// </summary>
    public static int GET_ENTITY_LOD_DIST(uint entity) => Function.Call<int>((Hash)0x4159C2762B5791D6,entity);

    // 0x44A0870B7E92D7C0
    /// <summary>
    /// Hash: 0x44A0870B7E92D7C0
    /// </summary>
    public static void SET_ENTITY_ALPHA(uint entity,int alphaLevel,bool skin) => Function.Call((Hash)0x44A0870B7E92D7C0,entity,alphaLevel,skin);

    // 0x5A47B3B5E63E94C6
    /// <summary>
    /// Hash: 0x5A47B3B5E63E94C6
    /// </summary>
    public static int GET_ENTITY_ALPHA(uint entity) => Function.Call<int>((Hash)0x5A47B3B5E63E94C6,entity);

    // 0x9B1E824FFBB7027A
    /// <summary>
    /// Hash: 0x9B1E824FFBB7027A
    /// </summary>
    public static void RESET_ENTITY_ALPHA(uint entity) => Function.Call((Hash)0x9B1E824FFBB7027A,entity);

    // 0x490861B88F4FD846
    /// <summary>
    /// Hash: 0x490861B88F4FD846
    /// </summary>
    public static void _0x490861B88F4FD846(uint entity) => Function.Call((Hash)0x490861B88F4FD846,entity);

    // 0xCEA7C8E1B48FF68C
    /// <summary>
    /// Hash: 0xCEA7C8E1B48FF68C
    /// </summary>
    public static void _0xCEA7C8E1B48FF68C(object p0,object p1) => Function.Call((Hash)0xCEA7C8E1B48FF68C,0,0);

    // 0x5C3B791D580E0BC2
    /// <summary>
    /// Hash: 0x5C3B791D580E0BC2
    /// </summary>
    public static void _0x5C3B791D580E0BC2(uint entity,float p1) => Function.Call((Hash)0x5C3B791D580E0BC2,entity,p1);

    // 0xACAD101E1FB66689
    /// <summary>
    /// Hash: 0xACAD101E1FB66689
    /// </summary>
    public static void SET_ENTITY_ALWAYS_PRERENDER(uint entity,bool toggle) => Function.Call((Hash)0xACAD101E1FB66689,entity,toggle);

    // 0x730F5F8D3F0F2050
    /// <summary>
    /// Hash: 0x730F5F8D3F0F2050
    /// </summary>
    public static void SET_ENTITY_RENDER_SCORCHED(uint entity,bool toggle) => Function.Call((Hash)0x730F5F8D3F0F2050,entity,toggle);

    // 0x57C5DB656185EAC4
    /// <summary>
    /// Hash: 0x57C5DB656185EAC4
    /// </summary>
    public static void SET_ENTITY_TRAFFICLIGHT_OVERRIDE(uint entity,int state) => Function.Call((Hash)0x57C5DB656185EAC4,entity,state);

    // 0x78E8E3A640178255
    /// <summary>
    /// Hash: 0x78E8E3A640178255
    /// </summary>
    public static void _0x78E8E3A640178255(uint entity) => Function.Call((Hash)0x78E8E3A640178255,entity);

    // 0x92C47782FDA8B2A3
    /// <summary>
    /// Hash: 0x92C47782FDA8B2A3
    /// </summary>
    public static void CREATE_MODEL_SWAP(float x,float y,float z,float radius,uint originalModel,uint newModel,bool p6) => Function.Call((Hash)0x92C47782FDA8B2A3,x,y,z,radius,originalModel,newModel,p6);

    // 0x033C0F9A64E229AE
    /// <summary>
    /// Hash: 0x033C0F9A64E229AE
    /// </summary>
    public static void REMOVE_MODEL_SWAP(float x,float y,float z,float radius,uint originalModel,uint newModel,bool p6) => Function.Call((Hash)0x033C0F9A64E229AE,x,y,z,radius,originalModel,newModel,p6);

    // 0x8A97BCA30A0CE478
    /// <summary>
    /// Hash: 0x8A97BCA30A0CE478
    /// </summary>
    public static void CREATE_MODEL_HIDE(float x,float y,float z,float radius,uint modelHash,bool p5) => Function.Call((Hash)0x8A97BCA30A0CE478,x,y,z,radius,modelHash,p5);

    // 0x3A52AE588830BF7F
    /// <summary>
    /// Hash: 0x3A52AE588830BF7F
    /// </summary>
    public static void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x,float y,float z,float radius,uint modelHash,bool p5) => Function.Call((Hash)0x3A52AE588830BF7F,x,y,z,radius,modelHash,p5);

    // 0xD9E3006FB3CBD765
    /// <summary>
    /// Hash: 0xD9E3006FB3CBD765
    /// </summary>
    public static void REMOVE_MODEL_HIDE(float x,float y,float z,float radius,uint modelHash,bool p5) => Function.Call((Hash)0xD9E3006FB3CBD765,x,y,z,radius,modelHash,p5);

    // 0xA53ED5520C07654A
    /// <summary>
    /// Hash: 0xA53ED5520C07654A
    /// </summary>
    public static void SET_ENTITY_NO_COLLISION_ENTITY(uint entity1,uint entity2,bool thisFrameOnly) => Function.Call((Hash)0xA53ED5520C07654A,entity1,entity2,thisFrameOnly);

    // 0x295D82A8559F9150
    /// <summary>
    /// Hash: 0x295D82A8559F9150
    /// </summary>
    public static void SET_ENTITY_MOTION_BLUR(uint entity,bool toggle) => Function.Call((Hash)0x295D82A8559F9150,entity,toggle);

    // 0xE12ABE5E3A389A6C
    /// <summary>
    /// Hash: 0xE12ABE5E3A389A6C
    /// </summary>
    public static void SET_CAN_AUTO_VAULT_ON_ENTITY(uint entity,bool toggle) => Function.Call((Hash)0xE12ABE5E3A389A6C,entity,toggle);

    // 0xA80AE305E0A3044F
    /// <summary>
    /// Hash: 0xA80AE305E0A3044F
    /// </summary>
    public static void SET_CAN_CLIMB_ON_ENTITY(uint entity,bool toggle) => Function.Call((Hash)0xA80AE305E0A3044F,entity,toggle);

    // 0xDC6F8601FAF2E893
    /// <summary>
    /// Hash: 0xDC6F8601FAF2E893
    /// </summary>
    public static void _0xDC6F8601FAF2E893(uint entity,bool toggle) => Function.Call((Hash)0xDC6F8601FAF2E893,entity,toggle);

    // 0x2C2E3DC128F44309
    /// <summary>
    /// Hash: 0x2C2E3DC128F44309
    /// </summary>
    public static void _SET_ENTITY_DECALS_DISABLED(uint entity,bool p1) => Function.Call((Hash)0x2C2E3DC128F44309,entity,p1);

    // 0x1A092BB0C3808B96
    /// <summary>
    /// Hash: 0x1A092BB0C3808B96
    /// </summary>
    public static void _0x1A092BB0C3808B96(uint entity,bool p1) => Function.Call((Hash)0x1A092BB0C3808B96,entity,p1);

    // 0xCE6294A232D03786
    /// <summary>
    /// Hash: 0xCE6294A232D03786
    /// </summary>
    public static Vector3 _GET_ENTITY_BONE_ROTATION(uint entity,int boneIndex) => Function.Call<Vector3>((Hash)0xCE6294A232D03786,entity,boneIndex);

    // 0x46F8696933A63C9B
    /// <summary>
    /// Hash: 0x46F8696933A63C9B
    /// </summary>
    public static Vector3 _GET_ENTITY_BONE_POSITION_2(uint entity,int boneIndex) => Function.Call<Vector3>((Hash)0x46F8696933A63C9B,entity,boneIndex);

    // 0xBD8D32550E5CEBFE
    /// <summary>
    /// Hash: 0xBD8D32550E5CEBFE
    /// </summary>
    public static Vector3 _GET_ENTITY_BONE_ROTATION_LOCAL(uint entity,int boneIndex) => Function.Call<Vector3>((Hash)0xBD8D32550E5CEBFE,entity,boneIndex);

    // 0xB328DCC3A3AA401B
    /// <summary>
    /// Hash: 0xB328DCC3A3AA401B
    /// </summary>
    public static int _GET_ENTITY_BONE_COUNT(uint entity) => Function.Call<int>((Hash)0xB328DCC3A3AA401B,entity);

    // 0x6CE177D014502E8A
    /// <summary>
    /// Hash: 0x6CE177D014502E8A
    /// </summary>
    public static void _ENABLE_ENTITY_UNK(uint entity) => Function.Call((Hash)0x6CE177D014502E8A,entity);

    // 0x68B562E124CC0AEF
    /// <summary>
    /// Hash: 0x68B562E124CC0AEF
    /// </summary>
    public static void _0x68B562E124CC0AEF(Pickup pickup,Pickup pickup2) => Function.Call((Hash)0x68B562E124CC0AEF,pickup,pickup2);

    // 0x1F922734E259BD26
    /// <summary>
    /// Hash: 0x1F922734E259BD26
    /// </summary>
    public static Entity _GET_ENTITY_PICKUP(uint entity,uint modelHash) => Function.Call<Entity>((Hash)0x1F922734E259BD26,entity,modelHash);

    // 0xD7B80E7C3BEFC396
    /// <summary>
    /// Hash: 0xD7B80E7C3BEFC396
    /// </summary>
    public static void _0xD7B80E7C3BEFC396(Pickup pickup,bool toggle) => Function.Call((Hash)0xD7B80E7C3BEFC396,pickup,toggle);

}
