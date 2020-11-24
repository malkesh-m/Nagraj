import * as React from 'react';

import { Form, Input, Modal } from 'antd';

import { FormComponentProps } from 'antd/lib/form';
import FormItem from 'antd/lib/form/FormItem';
import { L } from '../../../lib/abpUtility';
import rules from './createOrUpdateContact.validation';

export interface ICreateOrUpdateContactProps extends FormComponentProps {
  visible: boolean;
  modalType: string;
  onCreate: () => void;
  onCancel: () => void;
}

class CreateOrUpdateTenant extends React.Component<ICreateOrUpdateContactProps> {
  render() {
    const formItemLayout = {
      labelCol: {
        xs: { span: 6 },
        sm: { span: 6 },
        md: { span: 6 },
        lg: { span: 6 },
        xl: { span: 6 },
        xxl: { span: 6 },
      },
      wrapperCol: {
        xs: { span: 18 },
        sm: { span: 18 },
        md: { span: 18 },
        lg: { span: 18 },
        xl: { span: 18 },
        xxl: { span: 18 },
      },
    };

    const { getFieldDecorator } = this.props.form;
    const { visible, onCancel, onCreate } = this.props;

    return (
      <Modal visible={visible} onCancel={onCancel} onOk={onCreate} title={L('Contact')} width={550}>
        <Form>
                <FormItem label={L('First Name')} {...formItemLayout}>
                    {this.props.form.getFieldDecorator('firstName', { rules: rules.firstName })(<Input />)}
          </FormItem>
          <FormItem label={L('Last Name')} {...formItemLayout}>
            {this.props.form.getFieldDecorator('lastName', { rules: rules.lastName })(<Input />)}
          </FormItem>
          <FormItem label={L('City')} {...formItemLayout}>
            {this.props.form.getFieldDecorator('city', { rules: rules.city })(<Input />)}
          </FormItem>
          <FormItem label={L('Phone Number')} {...formItemLayout}>
            {getFieldDecorator('phoneNumber', { rules: rules.phoneNumber })(<Input />)}
          </FormItem>
        </Form>
      </Modal>
    );
  }
}

export default Form.create<ICreateOrUpdateContactProps>()(CreateOrUpdateTenant);
