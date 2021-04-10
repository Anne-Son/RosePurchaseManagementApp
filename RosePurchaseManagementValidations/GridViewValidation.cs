using System.Windows.Forms;
using RosePurchaseManagementCodeFirstFromDB;
using System.Diagnostics;

namespace RosePurchaseManagementValidations

{
    /// <summary>
    /// Validation methods for Orders, Inventory, and Purchase classes and associated DataGridView controlss
    /// DataGridView controls are set in the constructor, but can also be set as properties.
    /// </summary>
    public class GridViewValidation
    {
        public GridViewValidation()
        {

        }

        /// <summary>
        /// Validate order. Check for valid OrderId and RoseSizeId.
        /// This event fires after cell validation and valuechanged, and the focus moves from
        /// the current row to something different. Could be a tab or mouse move away from current
        /// row.
        /// 
        /// This seems to get triggered on ANY exited row, so it is a double check on
        /// already entered data.
        /// 
        /// Validation is actually done twice, once in this event, and the other in CellValidating.
        /// Could be optimized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewOrders_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];

            Debug.WriteLine("OrdersRowValidating started index " + e.RowIndex);

            // only validate if there is changed data. NewRow has no data in it to start.

            if (row == null || row.IsNewRow == true)
            {
                Debug.WriteLine("\tOrdersRowValidating row null or new row " + e.RowIndex);
                return;
            }

            if (gridView.IsCurrentRowDirty == false)
            {
                Debug.WriteLine("\tOrdersRowValidating row not dirty index " + e.RowIndex);
                return;
            }

            // the row is now bound to our entity. check to see if car and customer are valid.

            Order order = row.DataBoundItem as Order;

            if (order.IsValidOrderId() == false)
            {
                MessageBox.Show("OrdersRowValidating OrderId is missing or does not exist in the Order table: " + order.OrderID);
                Debug.WriteLine("\tOrdersRowValidating OrderId invalid: " + order);
                RowCancelNew(gridView, e.RowIndex);
                return;
            }

            if (order.IsValidRoseSizeId() == false)
            {
                MessageBox.Show("OrdersRowValidating RoseSizeId is missing or does not exist in the RoseSize table: " + order.RoseSizeID);
                Debug.WriteLine("\tOrdersRowValidating custId invalid: " + order);
                RowCancelNew(gridView, e.RowIndex);
                return;
            }

            Debug.WriteLine("\tOrdersRowValidating order validated: " + order);

        }

        /// <summary>
        /// Validate inventory. 
        /// Otherwise just make sure all of the  info is filled in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewFlowers_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];

            Debug.WriteLine("InventoryRowValidating started index " + e.RowIndex);

            // only validate if there is changed data. NewRow has no data in it to start.

            if (row == null || row.IsNewRow == true)
            {
                Debug.WriteLine("\tInventoryRowValidating row null or new row " + e.RowIndex);
                return;
            }

            if (gridView.IsCurrentRowDirty == false)
            {
                Debug.WriteLine("\tInventoryRowValidating row not dirty index " + e.RowIndex);
                return;
            }

            // the row is now bound to our entity

            Inventory inventory = row.DataBoundItem as Inventory;

            // make sure car info is complete

            if (inventory.InfoIsInvalid())
            {
                MessageBox.Show("Rose information is missing");
                RowCancelNew(gridView, e.RowIndex);
                Debug.WriteLine("\tInventoryRowValidating Rose data missing: " + inventory);
                return;
            }


        }

        /// <summary>
        /// Validate customer.
        /// Make sure all of the customer info is filled in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewPurchase_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];

            Debug.WriteLine("PurchaseRowValidating started index " + e.RowIndex);

            // only validate if there is changed data. NewRow has no data in it to start.

            if (row == null || row.IsNewRow == true)
            {
                Debug.WriteLine("\tPurchaseRowValidating row null or new row " + e.RowIndex);
                return;
            }

            if (gridView.IsCurrentRowDirty == false)
            {
                Debug.WriteLine("\tPurchaseRowValidating row not dirty index " + e.RowIndex);
                return;
            }

            // the row is now bound to our entity

            Purchase purchase = row.DataBoundItem as Purchase;

            // make sure purchase info is complete

            if (purchase.InfoIsInvalid())
            {
                MessageBox.Show("Purchase information is missing");
                RowCancelNew(gridView, e.RowIndex);
                Debug.WriteLine("\tPurchaseRowValidating purchase data missing: " + purchase + " row " + e.RowIndex);
                return;
            }

            Debug.WriteLine("\tPurchaseRowValidating purchase validated: " + purchase);
        }

        /// <summary>
        /// Cancel any row change in the underlying BindingList. This will propagate to the DataGridView.
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="index"></param>
        public void RowCancelNew(DataGridView gridView, int index)
        {
            // cancel any edit, and invalidate the row, which also repaints the control
            gridView.CancelEdit();
            gridView.InvalidateRow(index);

            // refresh the datagridview just for good measure

            gridView.Refresh();

        }

        /// <summary>
        /// To cancel an invalid cell, 
        /// call RowCancelNew(gridview, index) above but also
        /// set DataGridViewCellValidatingEventArgs.Cancel to true.
        /// Do not need to do this for RowValidating.
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        public void CellCancelNew(DataGridView gridView, DataGridViewCellValidatingEventArgs e)
        {
            RowCancelNew(gridView, e.RowIndex);
            e.Cancel = true;
        }

        /// <summary>
        /// Validate cells in the Purchase control. Only thing this does is to check for empty cells,
        /// as all cells are simple strings.
        /// 
        /// <para>Additional business logic can go here as well</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewPurchase_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            string columnName = gridView.Columns[e.ColumnIndex].DataPropertyName;
            string cellValue = e.FormattedValue.ToString().Trim();
            if (cellValue.Length == 0)
            {
                MessageBox.Show("Purchase field [" + columnName + "] is missing");
                CellCancelNew(gridView, e);

            }
        }

        /// <summary>
        /// Validate the cells in Inventory.
        /// Edit is cancelled if any field is empty or color for car
        /// has already been allocated to another car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewFlowers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            string columnName = gridView.Columns[e.ColumnIndex].DataPropertyName;
            string cellValue = e.FormattedValue.ToString().Trim();

            // only validate if we are editing

            if (row.Cells[e.ColumnIndex].IsInEditMode == false && cellValue.Length > 0)
                return;

            if (cellValue.Length == 0)
            {
                MessageBox.Show("Inventory field [" + columnName + "] is missing");
                CellCancelNew(gridView, e);
                return;
            }



        }

        /// <summary>
        /// Validate the cells in the Orders control.
        /// Make sure the OrderId is unique 
        /// Also make sure car and customer exist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            DataGridViewRow row = gridView.Rows[e.RowIndex];

            // we will determine which cell to validate depending on the property name

            string columnName = gridView.Columns[e.ColumnIndex].DataPropertyName;
            string cellValue = e.FormattedValue.ToString().Trim();

            // the cell edit has not yet been committed, so the cell Value is null. So we have
            // to use the formatted value instead.

            // should really check for IsCellDirty. The cell needs to have been edited to be checked.

            if (row.Cells[e.ColumnIndex].IsInEditMode == false && cellValue.Length > 0)
                return;

            // validate the id's entered for the order

            Order order = new Order();

            switch (columnName)
            {
                case "OrderID":

                    int orderId;
                    bool isValidOrderId = int.TryParse(cellValue, out orderId);

                    order.OrderID = orderId;

                    Debug.WriteLine("OrdersCellValidating: isValidOrderId " + isValidOrderId + " orderId " + orderId);

                    // Error car is not in inventory or is already ordered
                    if (order.isValidOrderId(true) == false)
                    {
                        // need to cancel the edit in the control, and the validating event as well.

                        MessageBox.Show("OrdersCellValidating: OrderId does not exist in Order is blank, or is already ordered: " + orderId);
                        CellCancelNew(gridView, e);
                    }

                    break;
                case "RoseSizeID":
                    int roseSizeId;
                    bool isValidRoseSizeId = int.TryParse(cellValue, out roseSizeId);

                    order.RoseSizeID = roseSizeId;
                    Debug.WriteLine("OrdersCellValidating: isValidRoseSizeId " + isValidRoseSizeId + " roseSizeId " + roseSizeId);

                    if (order.IsValidRoseSizeId() == false)
                    {
                        // need to cancel the edit in the control, and the validating event as well.

                        MessageBox.Show("OrdersCellValidating: RoseSizeId does not exist or is blank: " + roseSizeId);

                        CellCancelNew(gridView, e);
                    }
                    break;
            }
        }
    }
}
