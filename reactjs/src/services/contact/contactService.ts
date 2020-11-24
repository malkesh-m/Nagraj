import CreateContactInput from './dto/createContactInput';
import CreateContactOutput from './dto/createContactOutput';
import { EntityDto } from '../../services/dto/entityDto';
import { GetAllContactOutput } from './dto/getAllContactOutput';
import GetContactOutput from './dto/getContactOutput';
import { PagedResultDto } from '../../services/dto/pagedResultDto';
import { PagedContactResultRequestDto } from './dto/PagedContactResultRequestDto';
import UpdateContactInput from './dto/updateContactInput';
import UpdateContactOutput from './dto/updateContactOutput';
import http from '../httpService';

class ContactService {
    public async create(createContactInput: CreateContactInput): Promise<CreateContactOutput> {
        let result = await http.post('api/services/app/Contact/CreateContact', createContactInput);
        return result.data.result;
    }

    public async delete(entityDto: EntityDto) {
        let result = await http.delete('api/services/app/Contact/DeleteContact', { params: entityDto });
        return result.data;
    }

    public async get(entityDto: EntityDto): Promise<GetContactOutput> {
        let result = await http.get('api/services/app/Contact/GetContact', { params: entityDto });
        return result.data.result;
    }

    public async getAll(pagedFilterAndSortedRequest: PagedContactResultRequestDto): Promise<PagedResultDto<GetAllContactOutput>> {
        let result = await http.get('api/services/app/Contact/GetAllContact', { params: pagedFilterAndSortedRequest });
        return result.data.result;
    }

    public async update(updateContactInput: UpdateContactInput): Promise<UpdateContactOutput> {
        let result = await http.put('api/services/app/Contact/UpdateContact', updateContactInput);
        return result.data.result;
    }
}

export default new ContactService();
