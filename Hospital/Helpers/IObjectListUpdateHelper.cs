using BrightIdeasSoftware;
using Hospital.Common;

namespace Hospital.Helpers
{
    internal interface IObjectListUpdateHelper
    {
        void EditEntityInList<T>(T editedEntity, ObjectListView listView) where T : class, IIdEntity;
    }
}
