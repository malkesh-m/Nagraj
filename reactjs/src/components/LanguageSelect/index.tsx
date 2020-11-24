import './index.less';
import 'famfamfam-flags/dist/sprite/famfamfam-flags.css';

import * as React from 'react';

import { Dropdown, Icon, Menu } from 'antd';

import { L } from '../../lib/abpUtility';
import classNames from 'classnames';
declare var abp: any;

export interface ILanguageSelectProps {

}

class LanguageSelect extends React.Component<ILanguageSelectProps> {
  get languages() {
    return abp.localization.languages.filter((val: any) => {
      return !val.isDisabled;
    });
  }

  async changeLanguage(languageName: string) {

    abp.utils.setCookieValue(
      'Abp.Localization.CultureName',
      languageName,
      new Date(new Date().getTime() + 5 * 365 * 86400000), //5 year
      abp.appPath
    );

    window.location.reload();
  }

  get currentLanguage() {
    return abp.localization.currentLanguage;
  }

  render() {
    const langMenu = (
      <Menu className={'menu'} selectedKeys={[this.currentLanguage.name]}>
        {this.languages.map((item: any) => (
          <Menu.Item key={item.name} onClick={() => this.changeLanguage(item.name)}>
            <i className={item.icon} /> {item.displayName}
          </Menu.Item>
        ))}
      </Menu>
    );

    return (
      <Dropdown overlay={langMenu} placement="bottomRight">
        <Icon type="global" className={classNames('dropDown', 'className')} title={L('Languages')} />
      </Dropdown>
    );
  }
}

export default LanguageSelect;
