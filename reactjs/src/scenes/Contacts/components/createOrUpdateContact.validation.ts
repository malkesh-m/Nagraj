import { L } from '../../../lib/abpUtility';

const rules = {
  firstName: [{ required: true, message: L('ThisFieldIsRequired') }],
  lastName: [{ required: true, message: L('ThisFieldIsRequired') }],
  city: [{ required: false, message: L('ThisFieldIsRequired') }],
  phoneNumber: [{ required: false, message: L('ThisFieldIsRequired') }],
};

export default rules;
