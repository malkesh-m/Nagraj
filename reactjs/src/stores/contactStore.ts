import { action, observable } from 'mobx';

import CreateContactInput from '../services/contact/dto/createContactInput';
import { EntityDto } from '../services/dto/entityDto';
import { PagedResultDto } from '../services/dto/pagedResultDto';
import { PagedContactResultRequestDto } from '../services/contact/dto/PagedContactResultRequestDto';
import ContactModel from '../models/Contacts/ContactModel';
import UpdateContactInput from '../services/contact/dto/updateContactInput';
import contactService from '../services/contact/contactService';
import { GetAllContactOutput } from '../services/contact/dto/getAllContactOutput'


class ContactStore {
  @observable contacts!: PagedResultDto<GetAllContactOutput>;
  @observable contactModel: ContactModel = new ContactModel();

  @action
  async create(createContactInput: CreateContactInput) {
    await contactService.create(createContactInput);
  }

  @action
  async createContact() {
    this.contactModel = {
      id: 0,
      firstName: '',
      lastName: '',
      city: '',
      phoneNumber: ''
    };
  }

  @action
  async update(updateContactInput: UpdateContactInput) {
    let result = await contactService.update(updateContactInput);

    this.contacts.items = this.contacts.items.map((x: GetAllContactOutput) => {
      if (x.id === updateContactInput.id) x = result;
      return x;
    });
  }

  @action
  async delete(entityDto: EntityDto) {
    await contactService.delete(entityDto);
    this.contacts.items = this.contacts.items.filter((x: GetAllContactOutput) => x.id !== entityDto.id);
  }

  @action
  async get(entityDto: EntityDto) {
    let result = await contactService.get(entityDto);
    this.contactModel = result;
  }

  @action
  async getAll(pagedFilterAndSortedRequest: PagedContactResultRequestDto) {
    let result = await contactService.getAll(pagedFilterAndSortedRequest);
    this.contacts = result;
  }
}

export default ContactStore;
