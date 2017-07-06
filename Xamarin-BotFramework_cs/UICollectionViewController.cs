   public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = base.GetCell(collectionView, indexPath) as MessagesCollectionViewCell;
 
      
          //Bu bölüm gönderici için saklanýyor.
            var message = messages[indexPath.Row];
            if (message.SenderId == SenderId)
                cell.TextView.TextColor = UIColor.Black;
 
            return cell;
        }
 
        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return messages.Count;
        }
 
        public override IMessageData GetMessageData(MessagesCollectionView collectionView, NSIndexPath indexPath)
        {
            return messages[indexPath.Row];
        }
 
        public override IMessageBubbleImageDataSource GetMessageBubbleImageData(MessagesCollectionView collectionView, NSIndexPath indexPath)
        {
            var message = messages[indexPath.Row];
            if (message.SenderId == SenderId)
                return outgoingBubbleImageData;
            return incomingBubbleImageData;
 
        }
 
        public override IMessageAvatarImageDataSource GetAvatarImageData(MessagesCollectionView collectionView, NSIndexPath indexPath)
        {
            return null;
        }