using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PxU32 = System.UInt32;
using PxI32 = System.Int32;
namespace NVIDIA.Physix
{
    class PxVolumeCache
    {
        struct Iterator
        {
		    void processShapes(PxU32 count, PxActorShape actorShapePairs)
            { }
		    void finalizeQuery() {}
        };
	    enum FillStatus
	    {
		    FILL_OK,
		    FILL_OVER_MAX_COUNT,
		    FILL_UNSUPPORTED_GEOMETRY_TYPE,
		    FILL_OUT_OF_MEMORY
	    };
	    FillStatus fill(PxGeometry cacheVolume, PxTransform pose)
        { return FillStatus.FILL_OK; }
	    bool isValid()
        { return false; }
	    void invalidate()
        { }
	    bool getCacheVolume(PxGeometryHolder resultVolume, PxTransform resultPose)
        { return false; }
        PxI32 getNbCachedShapes()
        { return 0; }
	    void release()
        { }
	    void forEach(Iterator iter)
        { }
	    void setMaxNbStaticShapes(PxU32 maxCount)
        { }
	    void setMaxNbDynamicShapes(PxU32 maxCount)
        { }
        PxU32 getMaxNbStaticShapes()
        { return 0; }
	    PxU32 getMaxNbDynamicShapes()
        { return 0; }
        bool raycast(PxVec3 origin, PxVec3 unitDir, PxReal distance, PxRaycastCallback hitCall, PxHitFlags hitFlags = PxHitFlags.eDEFAULT,
	PxQueryFilterData filterData = null, PxQueryFilterCallback filterCall = null)
        { return false; }
	    bool sweep(PxGeometry geometry,  PxTransform pose,  PxVec3 unitDir,  PxReal distance,
        PxSweepCallback hitCall, PxHitFlags hitFlags = PxHitFlags.ePOSITION | PxHitFlags.eNORMAL | PxHitFlags.eDISTANCE,
            PxQueryFilterData filterData = null, PxQueryFilterCallback filterCall = null,
		    PxReal inflation = null)
        { return false; }
	    bool overlap(PxGeometry geometry, PxTransform pose, PxOverlapCallback hitCall, PxQueryFilterData filterData = null, 
        PxQueryFilterCallback filterCall = null)
        { return false; }
    }
}
