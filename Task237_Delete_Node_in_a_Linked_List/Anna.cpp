// https://pastebin.com/ii7jaRni

     void deleteNode(ListNode* node) {
        while (node->next->next) {
            node->val = node->next->val;
            node = node->next;
        }
        
        if (node->next) {
            node->val = node->next->val;
            delete node->next;
        }
        
        node->next = nullptr;
    }