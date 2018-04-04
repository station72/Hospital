using BrightIdeasSoftware;
using Hospital.Common;

namespace Hospital.Helpers
{
    internal class ObjectListUpdateHelper : IObjectListUpdateHelper
    {
        public void EditEntityInList<T>(T editedEntity, ObjectListView listView) where T : class, IIdEntity
        {
            var rowIndex = GetRowIndex<T>(editedEntity.Id, listView);
            if (!rowIndex.HasValue)
            {
                throw new HospitalException($"Row index has not been found. Entity id {editedEntity.Id}");
            }

            var listItem = listView.GetItem(rowIndex.Value);
            listItem.RowObject = editedEntity;
        }

        private int? GetRowIndex<T>(int institutionId, ObjectListView listView) where T : class, IIdEntity
        {
            for (int i = 0; i < listView.GetItemCount(); i++)
            {
                var item = listView.GetItem(i);
                var institution = item.RowObject as T;
                if (institution.Id == institutionId)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
