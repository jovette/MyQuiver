using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace MyQuiver.Tests.DataAccess
{
    public class MongoCollectionMock<TModel> : IMongoCollection<TModel> where TModel : class
    {
        public CollectionNamespace CollectionNamespace => throw new NotImplementedException();

        public IMongoDatabase Database => throw new NotImplementedException();

        public IBsonSerializer<TModel> DocumentSerializer => throw new NotImplementedException();

        public IMongoIndexManager<TModel> Indexes => throw new NotImplementedException();

        public MongoCollectionSettings Settings => throw new NotImplementedException();

        public IAsyncCursor<TResult> Aggregate<TResult>(PipelineDefinition<TModel, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<IAsyncCursor<TResult>> AggregateAsync<TResult>(PipelineDefinition<TModel, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public BulkWriteResult<TModel> BulkWrite(IEnumerable<WriteModel<TModel>> requests, BulkWriteOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<BulkWriteResult<TModel>> BulkWriteAsync(IEnumerable<WriteModel<TModel>> requests, BulkWriteOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public long Count(FilterDefinition<TModel> filter, CountOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<long> CountAsync(FilterDefinition<TModel> filter, CountOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteResult DeleteMany(FilterDefinition<TModel> filter, CancellationToken cancellationToken = default(CancellationToken))
        {
            return new DeleteResult.Acknowledged(new Random(DateTime.UtcNow.Millisecond).Next());
        }

        public DeleteResult DeleteMany(FilterDefinition<TModel> filter, DeleteOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            return new DeleteResult.Acknowledged(new Random(DateTime.UtcNow.Millisecond).Next());
        }

        public Task<DeleteResult> DeleteManyAsync(FilterDefinition<TModel> filter, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteManyAsync(FilterDefinition<TModel> filter, DeleteOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteResult DeleteOne(FilterDefinition<TModel> filter, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteResult DeleteOne(FilterDefinition<TModel> filter, DeleteOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteOneAsync(FilterDefinition<TModel> filter, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteOneAsync(FilterDefinition<TModel> filter, DeleteOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public IAsyncCursor<TField> Distinct<TField>(FieldDefinition<TModel, TField> field, FilterDefinition<TModel> filter, DistinctOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<IAsyncCursor<TField>> DistinctAsync<TField>(FieldDefinition<TModel, TField> field, FilterDefinition<TModel> filter, DistinctOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<IAsyncCursor<TProjection>> FindAsync<TProjection>(FilterDefinition<TModel> filter, FindOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public TProjection FindOneAndDelete<TProjection>(FilterDefinition<TModel> filter, FindOneAndDeleteOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<TProjection> FindOneAndDeleteAsync<TProjection>(FilterDefinition<TModel> filter, FindOneAndDeleteOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public TProjection FindOneAndReplace<TProjection>(FilterDefinition<TModel> filter, TModel replacement, FindOneAndReplaceOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<TProjection> FindOneAndReplaceAsync<TProjection>(FilterDefinition<TModel> filter, TModel replacement, FindOneAndReplaceOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public TProjection FindOneAndUpdate<TProjection>(FilterDefinition<TModel> filter, UpdateDefinition<TModel> update, FindOneAndUpdateOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<TProjection> FindOneAndUpdateAsync<TProjection>(FilterDefinition<TModel> filter, UpdateDefinition<TModel> update, FindOneAndUpdateOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public IAsyncCursor<TProjection> FindSync<TProjection>(FilterDefinition<TModel> filter, FindOptions<TModel, TProjection> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public void InsertMany(IEnumerable<TModel> documents, InsertManyOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(IEnumerable<TModel> documents, InsertManyOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public void InsertOne(TModel document, InsertOneOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
        }

        public Task InsertOneAsync(TModel document, CancellationToken _cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task InsertOneAsync(TModel document, InsertOneOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public IAsyncCursor<TResult> MapReduce<TResult>(BsonJavaScript map, BsonJavaScript reduce, MapReduceOptions<TModel, TResult> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<IAsyncCursor<TResult>> MapReduceAsync<TResult>(BsonJavaScript map, BsonJavaScript reduce, MapReduceOptions<TModel, TResult> options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public IFilteredMongoCollection<TDerivedDocument> OfType<TDerivedDocument>() where TDerivedDocument : TModel
        {
            throw new NotImplementedException();
        }

        public ReplaceOneResult ReplaceOne(FilterDefinition<TModel> filter, TModel replacement, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceOneResult> ReplaceOneAsync(FilterDefinition<TModel> filter, TModel replacement, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public UpdateResult UpdateMany(FilterDefinition<TModel> filter, UpdateDefinition<TModel> update, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResult> UpdateManyAsync(FilterDefinition<TModel> filter, UpdateDefinition<TModel> update, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public UpdateResult UpdateOne(FilterDefinition<TModel> filter, UpdateDefinition<TModel> update, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResult> UpdateOneAsync(FilterDefinition<TModel> filter, UpdateDefinition<TModel> update, UpdateOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public IMongoCollection<TModel> WithReadConcern(ReadConcern readConcern)
        {
            throw new NotImplementedException();
        }

        public IMongoCollection<TModel> WithReadPreference(ReadPreference readPreference)
        {
            throw new NotImplementedException();
        }

        public IMongoCollection<TModel> WithWriteConcern(WriteConcern writeConcern)
        {
            throw new NotImplementedException();
        }
    }
}
