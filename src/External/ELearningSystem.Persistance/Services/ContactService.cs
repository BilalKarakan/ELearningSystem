using AutoMapper;
using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.Contact;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class ContactService(IContactCommandRepository _commandRepository, IContactQueryRepository _queryRepository, IMapper _mapper) : IContactService
{
    public async Task CreateAsync(CreateContactCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<Contact>(request), cancellationToken);
    public void Delete(DeleteContactCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Contact>(request), cancellationToken);
    public void Update(UpdateContactCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Contact>(request), cancellationToken);
    public async Task<Contact> GetByIdAsync(GetOneContactQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<Contact>> GetListAsync(GetAllContactQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Contact> contacts = _queryRepository.GetQueryable(cancellationToken);

        int totalCount = await contacts.CountAsync();
        var items = await contacts.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync(cancellationToken);
        return new PagedResult<Contact>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
