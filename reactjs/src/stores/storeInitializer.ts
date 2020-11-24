import SessionStore from './sessionStore';
import AuthenticationStore from './authenticationStore';
import AccountStore from './accountStore';
import ContactStore from './contactStore';

export default function initializeStores() {
  return {
    authenticationStore: new AuthenticationStore(),
    sessionStore: new SessionStore(),
    accountStore: new AccountStore(),
    contactStore: new ContactStore(),
  };
}
